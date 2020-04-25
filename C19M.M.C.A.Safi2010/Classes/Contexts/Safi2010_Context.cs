namespace C19M.M.C.A.Safi2010.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Contexts;

    public sealed class Safi2010_Context : ISafi2010_Context
    {
        private ILog Log { get; }

        // Constructor
        public Safi2010_Context(
            FhirDecimal hospitalizationRateQuarantinedIndividuals,
            FhirDecimal effectiveContactRate,
            FhirDecimal naturalRecoveryRateInfectiousIndividuals,
            FhirDecimal recoveryRateHospitalizedIndividuals,
            FhirDecimal diseaseInducedDeathRateInfectiousIndividuals,
            FhirDecimal diseaseInducedDeathRateHospitalizedIndividuals,
            FhirDecimal efficacyIsolationTreatmentHospitalizedIndividuals,
            FhirDecimal developmentDiseaseSymptomsRateExposedIndividuals,
            FhirDecimal acquireInfectionRateSusceptibleIndividuals)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.HospitalizationRateQuarantinedIndividuals = hospitalizationRateQuarantinedIndividuals;

            this.EffectiveContactRate = effectiveContactRate;

            this.NaturalRecoveryRateInfectiousIndividuals = naturalRecoveryRateInfectiousIndividuals;

            this.RecoveryRateHospitalizedIndividuals = recoveryRateHospitalizedIndividuals;

            this.DiseaseInducedDeathRateInfectiousIndividuals = diseaseInducedDeathRateInfectiousIndividuals;

            this.DiseaseInducedDeathRateHospitalizedIndividuals = diseaseInducedDeathRateHospitalizedIndividuals;

            this.EfficacyIsolationTreatmentHospitalizedIndividuals = efficacyIsolationTreatmentHospitalizedIndividuals;

            this.DevelopmentDiseaseSymptomsRateExposedIndividuals = developmentDiseaseSymptomsRateExposedIndividuals;

            this.AcquireInfectionRateSusceptibleIndividuals = acquireInfectionRateSusceptibleIndividuals;
        }

        /// <summary>
        /// Gets the hospitalization rate for quarantined individuals.
        /// Parameter: α
        /// </summary>
        public FhirDecimal HospitalizationRateQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// </summary>
        public FhirDecimal EffectiveContactRate { get; }

        /// <summary>
        /// Gets the natural recovery rate for infectious individuals.
        /// Parameter: γ_1
        /// </summary>
        public FhirDecimal NaturalRecoveryRateInfectiousIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for hospitalized individuals.
        /// Parameter: γ_2
        /// </summary>
        public FhirDecimal RecoveryRateHospitalizedIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for infectious individuals.
        /// Parameter: δ_1
        /// </summary>
        public FhirDecimal DiseaseInducedDeathRateInfectiousIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for hospitalized individuals.
        /// Parameter: δ_2
        /// </summary>
        public FhirDecimal DiseaseInducedDeathRateHospitalizedIndividuals { get; }

        /// <summary>
        /// Gets the efficacy of isolation or treatment given to hospitalized individuals.
        /// Parameter: η
        /// </summary>
        public FhirDecimal EfficacyIsolationTreatmentHospitalizedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which exposed individuals develop disease symptoms.
        /// Parameter: κ
        /// </summary>
        public FhirDecimal DevelopmentDiseaseSymptomsRateExposedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which susceptible individuals acquire infections.
        /// Parameter: λ
        /// </summary>
        public FhirDecimal AcquireInfectionRateSusceptibleIndividuals { get; }
    }
}