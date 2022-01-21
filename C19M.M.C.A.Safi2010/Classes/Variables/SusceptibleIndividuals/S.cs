namespace C19M.M.C.A.Safi2010.Classes.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.SusceptibleIndividuals;

    internal sealed class S : IS
    {
        private ILog Log { get; }

        // Constructor
        public S(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdSdt(
            Iβ β,
            Iη η,
            Iλ λ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate.Iμ μ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals.IΠ Π,
            Iψ ψ,
            double H,
            double I,
            double N,
            double R,
            double S)
        {
            return
                Π.Value.Value.Value
                +
                ψ.Value.Value.Value
                *
                (decimal)R
                -
                λ.GetValue(
                    β,
                    η,
                    H,
                    I,
                    N)
                .Value
                .Value
                *
                (decimal)S
                -
                μ.Value.Value.Value
                *
                (decimal)S;
        }
    }
}