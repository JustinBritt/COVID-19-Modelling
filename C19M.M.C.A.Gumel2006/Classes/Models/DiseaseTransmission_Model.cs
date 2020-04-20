namespace C19M.M.C.A.Gumel2006.Classes.Models
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

    using C19M.M.C.A.Gumel2006.Classes.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.EquilibriumPopulationWithoutDisease;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.RecoveryRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.RecruitmentRateSusceptibleHumans;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.VaccinationCoverageRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.VaccineEfficacy;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Models;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EquilibriumPopulationWithoutDisease;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals;

    internal sealed class DiseaseTransmission_Model : IDiseaseTransmission_Model
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseTransmission_Model(
            IGumel2006_Context context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // d
            this.d = new C19M.M.C.A.Gumel2006.Classes.Parameters.DiseaseInducedMortalityRate.d(
                context.DiseaseInducedMortalityRate);

            // α
            this.α = new C19M.M.C.A.Gumel2006.Classes.Parameters.DevelopmentClinicalSymptomsRate.α(
                context.DevelopmentClinicalSymptomsRate);

            // β
            this.β = new C19M.M.C.A.Gumel2006.Classes.Parameters.EffectiveContactRate.β(
                context.EffectiveContactRate);

            // δ
            this.δ = new C19M.M.C.A.Gumel2006.Classes.Parameters.RecoveryRate.δ(
                context.RecoveryRate);

            // μ
            this.μ = new C19M.M.C.A.Gumel2006.Classes.Parameters.NaturalMortalityRate.μ(
                context.NaturalMortalityRate);

            // ξ
            this.ξ = new C19M.M.C.A.Gumel2006.Classes.Parameters.VaccinationCoverageRate.ξ(
                context.VaccinationCoverageRate);

            // Π
            this.Π = new C19M.M.C.A.Gumel2006.Classes.Parameters.RecruitmentRateSusceptibleHumans.Π(
                context.RecruitmentRateSusceptibleHumans);

            // τ
            this.τ = new C19M.M.C.A.Gumel2006.Classes.Parameters.VaccineEfficacy.τ(
                context.VaccineEfficacy);

            // Variables

            // E(t)
            this.E = new C19M.M.C.A.Gumel2006.Classes.Variables.LatentIndividuals.E(
                context.InitialValueLatentIndividuals);

            // I(t)
            this.I = new C19M.M.C.A.Gumel2006.Classes.Variables.InfectedIndividuals.I(
                context.InitialValueInfectedIndividuals);

            // R(t)
            this.R = new C19M.M.C.A.Gumel2006.Classes.Variables.TreatedIndividuals.R(
                context.InitialValueTreatedIndividuals);

            // S(t)
            this.S = new C19M.M.C.A.Gumel2006.Classes.Variables.SusceptibleIndividuals.S(
                context.InitialValueSusceptibleIndividuals);

            // V(t)
            this.V = new C19M.M.C.A.Gumel2006.Classes.Variables.VaccinatedIndividuals.V(
                context.InitialValueVaccinatedIndividuals);
        }

        public It t { get; }

        public C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate.Id d { get; }

        public Iα α { get; }

        public Iβ β { get; }

        public Iδ δ { get; }

        public Iμ μ { get; }

        public Iξ ξ { get; }

        public IΠ Π { get; }

        public Iτ τ { get; }

        public IE E { get; }

        public II I { get; }

        public IR R { get; }

        public IS S { get; }

        public IV V { get; }
    }
}