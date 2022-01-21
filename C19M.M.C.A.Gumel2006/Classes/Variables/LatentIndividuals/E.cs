namespace C19M.M.C.A.Gumel2006.Classes.Variables.LatentIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals;

    internal sealed class E : IE
    {
        private ILog Log { get; }

        // Constructor
        public E(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        // Equation (3)
        public decimal GetdEdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate.Iα α,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy.Iτ τ,
            double E,
            double I,
            double S,
            double V)
        {
            return
                β.Value.Value.Value * (decimal)S * (decimal)I
                +
                (1m - τ.Value.Value.Value) * β.Value.Value.Value * (decimal)V * (decimal)I
                -
                α.Value.Value.Value * (decimal)E
                -
                μ.Value.Value.Value * (decimal)E;
        }

        public decimal GetdEdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iγ γ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy.Iτ τ,
            double E,
            double I,
            double S,
            double V)
        {
            return
                β.Value.Value.Value * ((decimal)S + (1m - τ.Value.Value.Value) * (decimal)V) * (decimal)I
                -
                (γ.Value.Value.Value + ε.Value.Value.Value) * (decimal)E;
        }
    }
}