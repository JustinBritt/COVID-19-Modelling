namespace C19M.M.C.A.Gumel2006.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

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
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals;

    internal sealed class RescaledDiseaseTransmission_Model : IRescaledDiseaseTransmission_Model
    {
        private ILog Log { get; }

        // Constructor
        public RescaledDiseaseTransmission_Model(
            IGumel2006_Context context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // τ
            this.τ = new C19M.M.C.A.Gumel2006.Classes.Parameters.VaccineEfficacy.τ(
                context.VaccineEfficacy);

            // N
            this.N = new C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled.N(
                context.NaturalMortalityRate,
                context.RecruitmentRateSusceptibleHumans);

            // p
            this.p = new C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled.p(
                context.NaturalMortalityRate,
                context.VaccinationCoverageRate);

            // β
            this.β = new C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled.β(
                context.DiseaseInducedMortalityRate,
                context.EffectiveContactRate,
                context.RecoveryRate,
                context.NaturalMortalityRate);

            // γ
            this.γ = new C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled.γ(
                context.DiseaseInducedMortalityRate,
                context.DevelopmentClinicalSymptomsRate,
                context.RecoveryRate,
                context.NaturalMortalityRate);

            // ε
            this.ε = new C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled.ε(
                context.DiseaseInducedMortalityRate,
                context.RecoveryRate,
                context.NaturalMortalityRate);

            // Variables

            // E(t)

            // I(t)

            // S(t)

            // V(t)
        }

        public IN N { get; }

        public Ip p { get; }

        public Iβ β { get; }

        public Iγ γ { get; }

        public Iε ε { get; }

        public Iτ τ { get; }

        public IE E { get; }

        public II I { get; }

        public IS S { get; }

        public IV V { get; }
    }
}