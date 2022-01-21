namespace C19M.M.C.A.Safi2010.Classes.Variables.RecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.RecoveredIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        public R(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdRdt(
            C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals.Iγ γ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals.Iγ γ_2,
            Iμ μ,
            Iψ ψ,
            double H,
            double I,
            double R)
        {
            return
                γ_1.Value.Value.Value
                *
                (decimal)I
                +
                γ_2.Value.Value.Value
                *
                (decimal)H
                -
                (ψ.Value.Value.Value + μ.Value.Value.Value)
                *
                (decimal)R;
        }
    }
}