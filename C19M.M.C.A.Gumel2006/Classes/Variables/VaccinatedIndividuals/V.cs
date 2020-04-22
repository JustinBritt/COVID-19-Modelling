namespace C19M.M.C.A.Gumel2006.Classes.Variables.VaccinatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals;

    internal sealed class V : IV
    {
        private ILog Log { get; }

        // Constructor
        public V(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        // Equation (2)
        public decimal GetdVdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate.Iξ ξ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy.Iτ τ,
            double I,
            double S,
            double V)
        {
            return
                ξ.Value.Value.Value * (decimal)S
                -
                (1m - τ.Value.Value.Value) * β.Value.Value.Value * (decimal)V * (decimal)I
                -
                μ.Value.Value.Value * (decimal)V;
        }

        public decimal GetdVdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Ip p,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy.Iτ τ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            double I,
            double S,
            double V)
        {
            return
                -(1m - τ.Value.Value.Value) * β.Value.Value.Value * (decimal)V * (decimal)I
                +
                ε.Value.Value.Value * (((p.Value.Value.Value * (decimal)S) / (1m - p.Value.Value.Value)) - (decimal)V);
        }
    }
}