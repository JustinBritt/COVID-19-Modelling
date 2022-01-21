namespace C19M.M.C.A.Gumel2006.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    public sealed class Gumel2006_Context : IGumel2006_Context
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2006_Context(
            FhirDateTime endDate,
            Func<FhirDateTime, PositiveInt> numberDaysAfterStartDate,
            FhirDateTime startDate,
            FhirDecimal diseaseInducedMortalityRate,
            FhirDecimal initialValueLatentIndividuals,
            FhirDecimal initialValueInfectedIndividuals,
            FhirDecimal initialValueTreatedIndividuals,
            FhirDecimal initialValueSusceptibleIndividuals,
            FhirDecimal initialValueVaccinatedIndividuals,
            FhirDecimal developmentClinicalSymptomsRate,
            FhirDecimal effectiveContactRate,
            FhirDecimal recoveryRate,
            FhirDecimal naturalMortalityRate,
            FhirDecimal vaccinationCoverageRate,
            FhirDecimal recruitmentRateSusceptibleHumans,
            FhirDecimal vaccineEfficacy)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.EndDate = endDate;

            this.NumberDaysAfterStartDate = numberDaysAfterStartDate;

            this.StartDate = startDate;

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
        /// Gets the end date.
        /// Index: t
        /// </summary>
        public FhirDateTime EndDate { get; }

        /// <summary>
        /// Gets the number of days after the start date.
        /// Index: t
        /// </summary>
        public Func<FhirDateTime, PositiveInt> NumberDaysAfterStartDate { get; }

        /// <summary>
        /// Gets the start date.
        /// Index: t
        /// </summary>
        public FhirDateTime StartDate { get; }

        /// <summary>
        /// Gets the disease-induced mortality rate.
        /// Parameter: d
        /// Units: Per day
        /// </summary>
        public FhirDecimal DiseaseInducedMortalityRate { get; }

        /// <summary>
        /// Gets the initial value for latent individuals.
        /// Parameter: E(0)
        /// </summary>
        public FhirDecimal InitialValueLatentIndividuals { get; }

        /// <summary>
        /// Gets the initial value for infected individuals.
        /// Parameter: I(0)
        /// </summary>
        public FhirDecimal InitialValueInfectedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for treated individuals.
        /// Parameter: R(0)
        /// </summary>
        public FhirDecimal InitialValueTreatedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        public FhirDecimal InitialValueSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the initial value for vaccinated individuals
        /// Parameter: V(0)
        /// </summary>
        public FhirDecimal InitialValueVaccinatedIndividuals { get; }

        /// <summary>
        /// Gets the rate of development of clinical symptoms.
        /// Parameter: α
        /// Units: Per day
        /// </summary>
        public FhirDecimal DevelopmentClinicalSymptomsRate { get; }

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// Units: Per day
        /// </summary>
        public FhirDecimal EffectiveContactRate { get; }

        /// <summary>
        /// Gets the recovery rate.
        /// Parameter: δ
        /// Units: Per day
        /// </summary>
        public FhirDecimal RecoveryRate { get; }

        /// <summary>
        /// Gets the natural mortality rate.
        /// Parameter: μ
        /// Units: Per day
        /// </summary>
        public FhirDecimal NaturalMortalityRate { get; }

        /// <summary>
        /// Gets the vaccination coverage rate.
        /// Parameter: ξ
        /// Units: Per day
        /// </summary>
        public FhirDecimal VaccinationCoverageRate { get; }

        /// <summary>
        /// Gets the recruitment rate of susceptible humans.
        /// Parameter: Π
        /// Units: Per day
        /// </summary>
        public FhirDecimal RecruitmentRateSusceptibleHumans { get; }

        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// Parameter: τ
        /// </summary>
        public FhirDecimal VaccineEfficacy { get; }
    }
}