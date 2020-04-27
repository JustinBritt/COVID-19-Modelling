namespace C19M.M.C.A.Safi2010.Classes.Variables.HospitalizedIndividuals
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

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.HospitalizedIndividuals;

    internal sealed class H : IH
    {
        private ILog Log { get; }

        // Constructor
        public H(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdHdt(
            Iα α,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals.Iγ γ_2,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2,
            Iμ μ,
            Iϕ ϕ,
            double H,
            double I,
            double Q)
        {
            return
                α.Value.Value.Value * (decimal)Q
                -
                ϕ.Value.Value.Value * (decimal)I
                -
                (γ_2.Value.Value.Value + μ.Value.Value.Value + δ_2.Value.Value.Value) * (decimal)H;

        }
    }
}