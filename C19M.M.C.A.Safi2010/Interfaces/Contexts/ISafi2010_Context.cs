namespace C19M.M.C.A.Safi2010.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    public interface ISafi2010_Context
    {
        /// <summary>
        /// Gets the hospitalization rate for quarantined individuals.
        /// Parameter: α
        /// </summary>
        FhirDecimal HospitalizationRateQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// </summary>
        FhirDecimal EffectiveContactRate { get; }

        /// <summary>
        /// Gets the natural recovery rate for infectious individuals.
        /// Parameter: γ_1
        /// </summary>
        FhirDecimal NaturalRecoveryRateInfectiousIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for hospitalized individuals.
        /// Parameter: γ_2
        /// </summary>
        FhirDecimal RecoveryRateHospitalizedIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for infectious individuals.
        /// Parameter: δ_1
        /// </summary>
        FhirDecimal DiseaseInducedDeathRateInfectiousIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for hospitalized individuals.
        /// Parameter: δ_2
        /// </summary>
        FhirDecimal DiseaseInducedDeathRateHospitalizedIndividuals { get; }

        /// <summary>
        /// Gets the efficacy of isolation or treatment given to hospitalized individuals.
        /// Parameter: η
        /// </summary>
        FhirDecimal EfficacyIsolationTreatmentHospitalizedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which exposed individuals develop disease symptoms.
        /// Parameter: κ
        /// </summary>
        FhirDecimal DevelopmentDiseaseSymptomsRateExposedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which susceptible individuals acquire infections.
        /// Parameter: λ
        /// </summary>
        FhirDecimal AcquireInfectionRateSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// </summary>
        FhirDecimal NaturalDeathRate { get; }

        /// <summary>
        /// Gets the recruitment rate of susceptible individuals.
        /// Parameter: Π
        /// </summary>
        FhirDecimal RecruitmentRateSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the quarantine rate for exposed individuals.
        /// Parameter: σ
        /// </summary>
        FhirDecimal QuarantineRateExposedIndividuals { get; }

        /// <summary>
        /// Gets the hospitalization rate for infectious individuals.
        /// Parameter: ϕ
        /// </summary>
        FhirDecimal HospitalizationRateInfectiousIndividuals { get; }

        /// <summary>
        /// Gets the rate at which recovered individuals lose their infection-acquired immunity.
        /// Parameter: ψ
        /// </summary>
        FhirDecimal InfectionAcquiredImmunityLossRateRecoveredIndividuals { get; }
    }
}