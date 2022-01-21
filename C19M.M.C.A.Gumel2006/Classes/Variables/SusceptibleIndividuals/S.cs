namespace C19M.M.C.A.Gumel2006.Classes.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals;

    internal sealed class S : IS
    {
        private ILog Log { get; }

        public S(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }
        
        // Equation (1)
        public decimal GetdSdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate.Iξ ξ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans.IΠ Π,
            double I,
            double S)
        {
            return
                Π.Value.Value.Value
                -
                β.Value.Value.Value * (decimal)S * (decimal)I
                -
                ξ.Value.Value.Value * (decimal)S
                -
                μ.Value.Value.Value * (decimal)S;
        }

        public decimal GetdSdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.IN N,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Ip p,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            double I,
            double S)
        {
            return
                -β.Value.Value.Value * (decimal)S * (decimal)I
                +
                ε.Value.Value.Value * (N.Value.Value.Value - ((decimal)S / (1m - p.Value.Value.Value)));
        }
    }
}