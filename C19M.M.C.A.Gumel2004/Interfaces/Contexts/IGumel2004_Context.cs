namespace C19M.M.C.A.Gumel2004.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    public interface IGumel2004_Context
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
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// </summary>
        FhirDecimal DiseaseInducedDeathRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// Parameter: d_2
        /// </summary>
        FhirDecimal DiseaseInducedDeathRateIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for asymptomatic individuals.
        /// Parameter: E(0)
        /// </summary>
        FhirDecimal InitialValueAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for symptomatic individuals.
        /// Parameter: I(0)
        /// </summary>
        FhirDecimal InitialValueSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for isolated individuals.
        /// Parameter: J(0)
        /// </summary>
        FhirDecimal InitialValueIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// Parameter: p
        /// </summary>
        FhirDecimal RecruitmentRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for quarantined individuals.
        /// Parameter: Q(0)
        /// </summary>
        FhirDecimal InitialValueQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for recovered individuals.
        /// Parameter: R(0)
        /// </summary>
        FhirDecimal InitialValueRecoveredIndividuals { get; }

        /// <summary>
        /// Gets the basic reproduction number.
        /// Parameter: ℛ_0
        /// </summary>
        FhirDecimal BasicReproductionNumber { get; }

        /// <summary>
        /// Gets the control reproduction number.
        /// Parameter: ℛ_c
        /// </summary>
        FhirDecimal ControlReproductionNumber { get; }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        FhirDecimal InitialValueSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the basic transmission coefficient.
        /// Parameter: β
        /// </summary>
        FhirDecimal BasicTransmissionCoefficient { get; }

        /// <summary>
        /// Gets the quarantine rate for asymptomatic individuals.
        /// Parameter: γ_1
        /// </summary>
        Func<FhirDateTime, FhirDecimal> QuarantineRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// Parameter: γ_2
        /// </summary>
        Func<FhirDateTime, FhirDecimal> IsolationRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for asymptomatic individuals.
        /// Parameter: ε_E
        /// </summary>
        FhirDecimal TransmissionCoefficientModificationFactorAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// Parameter: ε_J
        /// </summary>
        Func<FhirDateTime, FhirDecimal> TransmissionCoefficientModificationFactorIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// Parameter: ε_Q
        /// </summary>
        Func<FhirDateTime, FhirDecimal> TransmissionCoefficientModificationFactorQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// Parameter: κ_1
        /// </summary>
        FhirDecimal DevelopmentClinicalSymptomsRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// Parameter: κ_2
        /// </summary>
        FhirDecimal DevelopmentClinicalSymptomsRateQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// </summary>
        FhirDecimal NaturalDeathRate { get; }

        /// <summary>
        /// Gets the net inflow rate of susceptible individuals per unit time.
        /// Parameter: Π
        /// </summary>
        FhirDecimal NetInflowRateSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for symptomatic individuals.
        /// Parameter: σ_1
        /// </summary>
        FhirDecimal RecoveryRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for isolated individuals.
        /// Parameter: σ_2
        /// </summary>
        FhirDecimal RecoveryRateIsolatedIndividuals { get; }
    }
}