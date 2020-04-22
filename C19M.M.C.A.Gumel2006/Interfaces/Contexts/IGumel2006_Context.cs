namespace C19M.M.C.A.Gumel2006.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    public interface IGumel2006_Context
    {
        /// <summary>
        /// Gets the end date.
        /// Index: t
        /// </summary>
        FhirDateTime EndDate { get; }

        /// <summary>
        /// Gets the number of days after the start date.
        /// Index: t
        /// </summary>
        Func<FhirDateTime, PositiveInt> NumberDaysAfterStartDate { get; }

        /// <summary>
        /// Gets the start date.
        /// Index: t
        /// </summary>
        FhirDateTime StartDate { get; }

        /// <summary>
        /// Gets the disease-induced mortality rate.
        /// Parameter: d
        /// Units: Per day
        /// </summary>
        FhirDecimal DiseaseInducedMortalityRate { get; }

        /// <summary>
        /// Gets the initial value for latent individuals.
        /// Parameter: E(0)
        /// </summary>
        FhirDecimal InitialValueLatentIndividuals { get; }

        /// <summary>
        /// Gets the initial value for infected individuals.
        /// Parameter: I(0)
        /// </summary>
        FhirDecimal InitialValueInfectedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for treated individuals.
        /// Parameter: R(0)
        /// </summary>
        FhirDecimal InitialValueTreatedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        FhirDecimal InitialValueSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the initial value for vaccinated individuals
        /// Parameter: V(0)
        /// </summary>
        FhirDecimal InitialValueVaccinatedIndividuals { get; }

        /// <summary>
        /// Gets the rate of development of clinical symptoms.
        /// Parameter: α
        /// Units: Per day
        /// </summary>
        FhirDecimal DevelopmentClinicalSymptomsRate { get; }

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// Units: Per day
        /// </summary>
        FhirDecimal EffectiveContactRate { get; }

        /// <summary>
        /// Gets the recovery rate.
        /// Parameter: δ
        /// Units: Per day
        /// </summary>
        FhirDecimal RecoveryRate { get; }

        /// <summary>
        /// Gets the natural mortality rate.
        /// Parameter: μ
        /// Units: Per day
        /// </summary>
        FhirDecimal NaturalMortalityRate { get; }

        /// <summary>
        /// Gets the vaccination coverage rate.
        /// Parameter: ξ
        /// Units: Per day
        /// </summary>
        FhirDecimal VaccinationCoverageRate { get; }

        /// <summary>
        /// Gets the recruitment rate of susceptible humans.
        /// Parameter: Π
        /// Units: Per day
        /// </summary>
        FhirDecimal RecruitmentRateSusceptibleHumans { get; }

        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// Parameter: τ
        /// </summary>
        FhirDecimal VaccineEfficacy { get; }
    }
}