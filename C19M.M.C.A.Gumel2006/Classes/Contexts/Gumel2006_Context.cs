namespace C19M.M.C.A.Gumel2006.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    public sealed class Gumel2006_Context : IGumel2006_Context
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2006_Context(
            double diseaseInducedMortalityRate,
            double initialValueLatentIndividuals,
            double initialValueInfectedIndividuals,
            double initialValueTreatedIndividuals,
            double initialValueSusceptibleIndividuals,
            double initialValueVaccinatedIndividuals,
            double developmentClinicalSymptomsRate,
            double effectiveContactRate,
            double recoveryRate,
            double naturalMortalityRate,
            double vaccinationCoverageRate,
            double recruitmentRateSusceptibleHumans,
            double vaccineEfficacy)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.DiseaseInducedMortalityRate = diseaseInducedMortalityRate;

            this.InitialValueLatentIndividuals = initialValueLatentIndividuals;

            this.InitialValueInfectedIndividuals = initialValueInfectedIndividuals;

            this.InitialValueTreatedIndividuals = initialValueTreatedIndividuals;

            this.InitialValueSusceptibleIndividuals = initialValueSusceptibleIndividuals;

            this.InitialValueVaccinatedIndividuals = initialValueVaccinatedIndividuals;

            this.DevelopmentClinicalSymptomsRate = developmentClinicalSymptomsRate;

            this.EffectiveContactRate = effectiveContactRate;

            this.RecoveryRate = recoveryRate;

            this.NaturalMortalityRate = naturalMortalityRate;

            this.VaccinationCoverageRate = vaccinationCoverageRate;

            this.RecruitmentRateSusceptibleHumans = recruitmentRateSusceptibleHumans;

            this.VaccineEfficacy = vaccineEfficacy;
        }

        /// <summary>
        /// Gets the disease-induced mortality rate.
        /// Parameter: d
        /// Units: Per day
        /// </summary>
        public double DiseaseInducedMortalityRate { get; }

        /// <summary>
        /// Gets the initial value for latent individuals.
        /// Parameter: E(0)
        /// </summary>
        public double InitialValueLatentIndividuals { get; }

        /// <summary>
        /// Gets the initial value for infected individuals.
        /// Parameter: I(0)
        /// </summary>
        public double InitialValueInfectedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for treated individuals.
        /// Parameter: R(0)
        /// </summary>
        public double InitialValueTreatedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        public double InitialValueSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the initial value for vaccinated individuals
        /// Parameter: V(0)
        /// </summary>
        public double InitialValueVaccinatedIndividuals { get; }

        /// <summary>
        /// Gets the rate of development of clinical symptoms.
        /// Parameter: α
        /// Units: Per day
        /// </summary>
        public double DevelopmentClinicalSymptomsRate { get; }

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// Units: Per day
        /// </summary>
        public double EffectiveContactRate { get; }

        /// <summary>
        /// Gets the recovery rate.
        /// Parameter: δ
        /// Units: Per day
        /// </summary>
        public double RecoveryRate { get; }

        /// <summary>
        /// Gets the natural mortality rate.
        /// Parameter: μ
        /// Units: Per day
        /// </summary>
        public double NaturalMortalityRate { get; }

        /// <summary>
        /// Gets the vaccination coverage rate.
        /// Parameter: ξ
        /// Units: Per day
        /// </summary>
        public double VaccinationCoverageRate { get; }

        /// <summary>
        /// Gets the recruitment rate of susceptible humans.
        /// Parameter: Π
        /// Units: Per day
        /// </summary>
        public double RecruitmentRateSusceptibleHumans { get; }

        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// Parameter: τ
        /// </summary>
        public double VaccineEfficacy { get; }
    }
}