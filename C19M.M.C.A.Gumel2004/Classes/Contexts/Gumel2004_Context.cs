namespace C19M.M.C.A.Gumel2004.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Contexts;

    public sealed class Gumel2004_Context : IGumel2004_Context
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Context(
            FhirDateTime endDate,
            Func<FhirDateTime, PositiveInt> numberDaysAfterStartDate,
            FhirDateTime startDate,
            FhirDecimal diseaseInducedDeathRateSymptomaticIndividuals,
            FhirDecimal diseaseInducedDeathRateIsolatedIndividuals,
            FhirDecimal initialValueAsymptomaticIndividuals,
            FhirDecimal initialValueSymptomaticIndividuals,
            FhirDecimal initialValueIsolatedIndividuals,
            FhirDecimal recruitmentRateAsymptomaticIndividuals,
            FhirDecimal initialValueQuarantinedIndividuals,
            FhirDecimal initialValueRecoveredIndividuals,
            FhirDecimal basicReproductionNumber,
            FhirDecimal controlReproductionNumber,
            FhirDecimal initialValueSusceptibleIndividuals,
            FhirDecimal basicTransmissionCoefficient,
            Func<FhirDateTime, FhirDecimal> quarantineRateAsymptomaticIndividuals,
            Func<FhirDateTime, FhirDecimal> isolationRateSymptomaticIndividuals,
            FhirDecimal transmissionCoefficientModificationFactorAsymptomaticIndividuals,
            Func<FhirDateTime, FhirDecimal> transmissionCoefficientModificationFactorIsolatedIndividuals,
            Func<FhirDateTime, FhirDecimal> transmissionCoefficientModificationFactorQuarantinedIndividuals,
            FhirDecimal developmentClinicalSymptomsRateAsymptomaticIndividuals,
            FhirDecimal developmentClinicalSymptomsRateQuarantinedIndividuals,
            FhirDecimal naturalDeathRate,
            FhirDecimal netInflowRateSusceptibleIndividuals,
            FhirDecimal recoveryRateSymptomaticIndividuals,
            FhirDecimal recoveryRateIsolatedIndividuals)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.EndDate = endDate;

            this.NumberDaysAfterStartDate = numberDaysAfterStartDate;

            this.StartDate = startDate;

            this.DiseaseInducedDeathRateSymptomaticIndividuals = diseaseInducedDeathRateSymptomaticIndividuals;

            this.DiseaseInducedDeathRateIsolatedIndividuals = diseaseInducedDeathRateIsolatedIndividuals;

            this.InitialValueAsymptomaticIndividuals = initialValueAsymptomaticIndividuals;

            this.InitialValueSymptomaticIndividuals = initialValueSymptomaticIndividuals;

            this.InitialValueIsolatedIndividuals = initialValueIsolatedIndividuals;

            this.RecruitmentRateAsymptomaticIndividuals = recruitmentRateAsymptomaticIndividuals;

            this.InitialValueQuarantinedIndividuals = initialValueQuarantinedIndividuals;

            this.InitialValueRecoveredIndividuals = initialValueRecoveredIndividuals;

            this.BasicReproductionNumber = basicReproductionNumber;

            this.ControlReproductionNumber = controlReproductionNumber;

            this.InitialValueSusceptibleIndividuals = initialValueSusceptibleIndividuals;

            this.BasicTransmissionCoefficient = basicTransmissionCoefficient;

            this.QuarantineRateAsymptomaticIndividuals = quarantineRateAsymptomaticIndividuals;

            this.IsolationRateSymptomaticIndividuals = isolationRateSymptomaticIndividuals;

            this.TransmissionCoefficientModificationFactorAsymptomaticIndividuals = transmissionCoefficientModificationFactorAsymptomaticIndividuals;

            this.TransmissionCoefficientModificationFactorIsolatedIndividuals = transmissionCoefficientModificationFactorIsolatedIndividuals;

            this.TransmissionCoefficientModificationFactorQuarantinedIndividuals = transmissionCoefficientModificationFactorQuarantinedIndividuals;

            this.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals = developmentClinicalSymptomsRateAsymptomaticIndividuals;

            this.DevelopmentClinicalSymptomsRateQuarantinedIndividuals = developmentClinicalSymptomsRateQuarantinedIndividuals;

            this.NaturalDeathRate = naturalDeathRate;

            this.NetInflowRateSusceptibleIndividuals = netInflowRateSusceptibleIndividuals;

            this.RecoveryRateSymptomaticIndividuals = recoveryRateSymptomaticIndividuals;

            this.RecoveryRateIsolatedIndividuals = recoveryRateIsolatedIndividuals;
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
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// </summary>
        public FhirDecimal DiseaseInducedDeathRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// Parameter: d_2
        /// </summary>
        public FhirDecimal DiseaseInducedDeathRateIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for asymptomatic individuals.
        /// Parameter: E(0)
        /// </summary>
        public FhirDecimal InitialValueAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for symptomatic individuals.
        /// Parameter: I(0)
        /// </summary>
        public FhirDecimal InitialValueSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for isolated individuals.
        /// Parameter: J(0)
        /// </summary>
        public FhirDecimal InitialValueIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// Parameter: p
        /// </summary>
        public FhirDecimal RecruitmentRateAsymptomaticIndividuals { get; }

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
        /// Gets the basic reproduction number.
        /// Parameter: ℛ_0
        /// </summary>
        public FhirDecimal BasicReproductionNumber { get; }

        /// <summary>
        /// Gets the control reproduction number.
        /// Parameter: ℛ_c
        /// </summary>
        public FhirDecimal ControlReproductionNumber { get; }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        public FhirDecimal InitialValueSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the basic transmission coefficient.
        /// Parameter: β
        /// </summary>
        public FhirDecimal BasicTransmissionCoefficient { get; }

        /// <summary>
        /// Gets the quarantine rate for asymptomatic individuals.
        /// Parameter: γ_1
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> QuarantineRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// Parameter: γ_2
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> IsolationRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for asymptomatic individuals.
        /// Parameter: ε_E
        /// </summary>
        public FhirDecimal TransmissionCoefficientModificationFactorAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// Parameter: ε_J
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> TransmissionCoefficientModificationFactorIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// Parameter: ε_Q
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> TransmissionCoefficientModificationFactorQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// Parameter: κ_1
        /// </summary>
        public FhirDecimal DevelopmentClinicalSymptomsRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// Parameter: κ_2
        /// </summary>
        public FhirDecimal DevelopmentClinicalSymptomsRateQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// </summary>
        public FhirDecimal NaturalDeathRate { get; }

        /// <summary>
        /// Gets the net inflow rate of susceptible individuals per unit time.
        /// Parameter: Π
        /// </summary>
        public FhirDecimal NetInflowRateSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for symptomatic individuals.
        /// Parameter: σ_1
        /// </summary>
        public FhirDecimal RecoveryRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for isolated individuals.
        /// Parameter: σ_2
        /// </summary>
        public FhirDecimal RecoveryRateIsolatedIndividuals { get; }
    }
}