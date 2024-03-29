﻿namespace C19M.M.C.A.Safi2010.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Contexts;

    public sealed class Safi2010_Context : ISafi2010_Context
    {
        private ILog Log { get; }

        public Safi2010_Context(
            FhirDateTime endDate,
            Func<FhirDateTime, PositiveInt> numberDaysAfterStartDate,
            FhirDateTime startDate,
            FhirDecimal initialValueExposedIndividuals,
            FhirDecimal initialValueHospitalizedIndividuals,
            FhirDecimal initialValueInfectiousIndividuals,
            FhirDecimal initialValueQuarantinedIndividuals,
            FhirDecimal initialValueRecoveredIndividuals,
            FhirDecimal initialValueSusceptibleIndividuals,
            FhirDecimal hospitalizationRateQuarantinedIndividuals,
            FhirDecimal effectiveContactRate,
            FhirDecimal naturalRecoveryRateInfectiousIndividuals,
            FhirDecimal recoveryRateHospitalizedIndividuals,
            FhirDecimal diseaseInducedDeathRateInfectiousIndividuals,
            FhirDecimal diseaseInducedDeathRateHospitalizedIndividuals,
            FhirDecimal efficacyIsolationTreatmentHospitalizedIndividuals,
            FhirDecimal developmentDiseaseSymptomsRateExposedIndividuals,
            FhirDecimal acquireInfectionRateSusceptibleIndividuals,
            FhirDecimal naturalDeathRate,
            FhirDecimal recruitmentRateSusceptibleIndividuals,
            FhirDecimal quarantineRateExposedIndividuals,
            FhirDecimal hospitalizationRateInfectiousIndividuals,
            FhirDecimal infectionAcquiredImmunityLossRateRecoveredIndividuals)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.EndDate = endDate;

            this.NumberDaysAfterStartDate = numberDaysAfterStartDate;

            this.StartDate = startDate;

            this.InitialValueExposedIndividuals = initialValueExposedIndividuals;

            this.InitialValueHospitalizedIndividuals = initialValueHospitalizedIndividuals;

            this.InitialValueInfectiousIndividuals = initialValueInfectiousIndividuals;

            this.InitialValueQuarantinedIndividuals = initialValueQuarantinedIndividuals;

            this.InitialValueRecoveredIndividuals = initialValueRecoveredIndividuals;

            this.InitialValueSusceptibleIndividuals = initialValueSusceptibleIndividuals;

            this.HospitalizationRateQuarantinedIndividuals = hospitalizationRateQuarantinedIndividuals;

            this.EffectiveContactRate = effectiveContactRate;

            this.NaturalRecoveryRateInfectiousIndividuals = naturalRecoveryRateInfectiousIndividuals;

            this.RecoveryRateHospitalizedIndividuals = recoveryRateHospitalizedIndividuals;

            this.DiseaseInducedDeathRateInfectiousIndividuals = diseaseInducedDeathRateInfectiousIndividuals;

            this.DiseaseInducedDeathRateHospitalizedIndividuals = diseaseInducedDeathRateHospitalizedIndividuals;

            this.EfficacyIsolationTreatmentHospitalizedIndividuals = efficacyIsolationTreatmentHospitalizedIndividuals;

            this.DevelopmentDiseaseSymptomsRateExposedIndividuals = developmentDiseaseSymptomsRateExposedIndividuals;

            this.AcquireInfectionRateSusceptibleIndividuals = acquireInfectionRateSusceptibleIndividuals;

            this.NaturalDeathRate = naturalDeathRate;

            this.RecruitmentRateSusceptibleIndividuals = recruitmentRateSusceptibleIndividuals;

            this.QuarantineRateExposedIndividuals = quarantineRateExposedIndividuals;

            this.HospitalizationRateInfectiousIndividuals = hospitalizationRateInfectiousIndividuals;

            this.InfectionAcquiredImmunityLossRateRecoveredIndividuals = infectionAcquiredImmunityLossRateRecoveredIndividuals;
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
        /// Gets the initial value for exposed individuals.
        /// Parameter: E(0)
        /// </summary>
        public FhirDecimal InitialValueExposedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for hospitalized individuals.
        /// Parameter: H(0)
        /// </summary>
        public FhirDecimal InitialValueHospitalizedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for infectious individuals.
        /// Parameter: I(0)
        /// </summary>
        public FhirDecimal InitialValueInfectiousIndividuals { get; }

        /// <summary>
        /// Gets the initial value for quarantined individuals.
        /// Parameter: Q(0)
        /// </summary>
        public FhirDecimal InitialValueQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for recovered individuals.
        /// Parameter: R(0)
        /// </summary>
        public FhirDecimal InitialValueRecoveredIndividuals { get; }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        public FhirDecimal InitialValueSusceptibleIndividuals { get; }

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

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// </summary>
        public FhirDecimal NaturalDeathRate { get; }

        /// <summary>
        /// Gets the recruitment rate of susceptible individuals.
        /// Parameter: Π
        /// </summary>
        public FhirDecimal RecruitmentRateSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the quarantine rate for exposed individuals.
        /// Parameter: σ
        /// </summary>
        public FhirDecimal QuarantineRateExposedIndividuals { get; }

        /// <summary>
        /// Gets the hospitalization rate for infectious individuals.
        /// Parameter: ϕ
        /// </summary>
        public FhirDecimal HospitalizationRateInfectiousIndividuals { get; }

        /// <summary>
        /// Gets the rate at which recovered individuals lose their infection-acquired immunity.
        /// Parameter: ψ
        /// </summary>
        public FhirDecimal InfectionAcquiredImmunityLossRateRecoveredIndividuals { get; }
    }
}