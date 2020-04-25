namespace C19M.M.C.A.Safi2010.Classes.Models
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

    using C19M.M.C.A.Safi2010.Interfaces.Contexts;

    using C19M.M.C.A.Safi2010.Interfaces.Models;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.ExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.HospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.InfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.QuarantinedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.RecoveredIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.TotalPopulationSize;

    internal sealed class Equations2_Model : IEquations2_Model
    {
        private ILog Log { get; }

        // Constructor
        public Equations2_Model()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // α

            // β

            // γ_1

            // γ_2

            // δ_1

            // δ_2

            // η

            // κ

            // λ

            // μ

            // Π

            // σ

            // ϕ

            // ψ

            // Variables

            // E(t)

            // H(t)

            // I(t)

            // N(t)

            // Q(t)

            // R(t)

            // S(t)
        }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals.Iα α { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate.Iβ β { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals.Iγ γ_1 { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals.Iγ γ_2 { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1 { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2 { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals.Iη η { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals.Iκ κ { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals.Iλ λ { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate.Iμ μ { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals.IΠ Π { get; }
        
        public C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals.Iσ σ { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals.Iϕ ϕ { get; }

        public C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals.Iψ ψ { get; }

        public IE E { get; }

        public IH H { get; }

        public II I { get; }

        public IN N { get; }

        public IQ Q { get; }

        public IR R { get; }

        public IS S { get; }
    }
}