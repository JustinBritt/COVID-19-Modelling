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
    using System.Runtime.Remoting.Contexts;

    internal sealed class Equations2_Model : IEquations2_Model
    {
        private ILog Log { get; }

        // Constructor
        public Equations2_Model(
            ISafi2010_Context Safi2010_Context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // α
            this.α = new C19M.M.C.A.Safi2010.Classes.Parameters.HospitalizationRateQuarantinedIndividuals.α(
                Safi2010_Context.HospitalizationRateQuarantinedIndividuals);

            // β
            this.β = new C19M.M.C.A.Safi2010.Classes.Parameters.EffectiveContactRate.β(
                Safi2010_Context.EffectiveContactRate);

            // γ_1
            this.γ_1 = new C19M.M.C.A.Safi2010.Classes.Parameters.NaturalRecoveryRateInfectiousIndividuals.γ(
                Safi2010_Context.NaturalRecoveryRateInfectiousIndividuals);

            // γ_2
            this.γ_2 = new C19M.M.C.A.Safi2010.Classes.Parameters.RecoveryRateHospitalizedIndividuals.γ(
                Safi2010_Context.RecoveryRateHospitalizedIndividuals);

            // δ_1
            this.δ_1 = new C19M.M.C.A.Safi2010.Classes.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.δ(
                Safi2010_Context.DiseaseInducedDeathRateInfectiousIndividuals);

            // δ_2
            this.δ_2 = new C19M.M.C.A.Safi2010.Classes.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.δ(
                Safi2010_Context.DiseaseInducedDeathRateHospitalizedIndividuals);

            // η
            this.η = new C19M.M.C.A.Safi2010.Classes.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals.η(
                Safi2010_Context.EfficacyIsolationTreatmentHospitalizedIndividuals);

            // κ
            this.κ = new C19M.M.C.A.Safi2010.Classes.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals.κ(
                Safi2010_Context.DevelopmentDiseaseSymptomsRateExposedIndividuals);

            // λ
            this.λ = new C19M.M.C.A.Safi2010.Classes.Parameters.AcquireInfectionRateSusceptibleIndividuals.λ();

            // μ
            this.μ = new C19M.M.C.A.Safi2010.Classes.Parameters.NaturalDeathRate.μ(
                Safi2010_Context.NaturalDeathRate);

            // Π
            this.Π = new C19M.M.C.A.Safi2010.Classes.Parameters.RecruitmentRateSusceptibleIndividuals.Π(
                Safi2010_Context.RecruitmentRateSusceptibleIndividuals);

            // σ
            this.σ = new C19M.M.C.A.Safi2010.Classes.Parameters.QuarantineRateExposedIndividuals.σ(
                Safi2010_Context.QuarantineRateExposedIndividuals);

            // ϕ
            this.ϕ = new C19M.M.C.A.Safi2010.Classes.Parameters.HospitalizationRateInfectiousIndividuals.ϕ(
                Safi2010_Context.HospitalizationRateInfectiousIndividuals);

            // ψ
            this.ψ = new C19M.M.C.A.Safi2010.Classes.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals.ψ(
                Safi2010_Context.InfectionAcquiredImmunityLossRateRecoveredIndividuals);

            // Variables

            // E(t)
            this.E = new C19M.M.C.A.Safi2010.Classes.Variables.ExposedIndividuals.E(
                Safi2010_Context.InitialValueExposedIndividuals);

            // H(t)
            this.H = new C19M.M.C.A.Safi2010.Classes.Variables.HospitalizedIndividuals.H(
                Safi2010_Context.InitialValueHospitalizedIndividuals);

            // I(t)
            this.I = new C19M.M.C.A.Safi2010.Classes.Variables.InfectiousIndividuals.I(
                Safi2010_Context.InitialValueInfectiousIndividuals);

            // N(t)

            // Q(t)
            this.Q = new C19M.M.C.A.Safi2010.Classes.Variables.QuarantinedIndividuals.Q(
                Safi2010_Context.InitialValueQuarantinedIndividuals);

            // R(t)
            this.R = new C19M.M.C.A.Safi2010.Classes.Variables.RecoveredIndividuals.R(
                Safi2010_Context.InitialValueRecoveredIndividuals);

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