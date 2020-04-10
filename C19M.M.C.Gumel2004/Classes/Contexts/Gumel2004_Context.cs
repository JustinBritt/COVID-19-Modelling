﻿namespace C19M.M.C.Gumel2004.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Contexts;

    public sealed class Gumel2004_Context : IGumel2004_Context
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Context(
            double diseaseInducedDeathRateSymptomaticIndividuals,
            double diseaseInducedDeathRateIsolatedIndividuals,
            double recruitmentRateAsymptomaticIndividuals,
            double basicReproductionNumber,
            double controlReproductionNumber,
            double basicTransmissionCoefficient,
            double quarantineRateAsymptomaticIndividuals,
            double isolationRateSymptomaticIndividuals,
            double transmissionCoefficientModificationFactorAsymptomaticIndividuals,
            double transmissionCoefficientModificationFactorIsolatedIndividuals,
            double transmissionCoefficientModificationFactorQuarantinedIndividuals,
            double developmentClinicalSymptomsRateAsymptomaticIndividuals,
            double developmentClinicalSymptomsRateQuarantinedIndividuals,
            double naturalDeathRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.DiseaseInducedDeathRateSymptomaticIndividuals = diseaseInducedDeathRateSymptomaticIndividuals;

            this.DiseaseInducedDeathRateIsolatedIndividuals = diseaseInducedDeathRateIsolatedIndividuals;

            this.RecruitmentRateAsymptomaticIndividuals = recruitmentRateAsymptomaticIndividuals;

            this.BasicReproductionNumber = basicReproductionNumber;

            this.ControlReproductionNumber = controlReproductionNumber;

            this.BasicTransmissionCoefficient = basicTransmissionCoefficient;

            this.QuarantineRateAsymptomaticIndividuals = quarantineRateAsymptomaticIndividuals;

            this.IsolationRateSymptomaticIndividuals = isolationRateSymptomaticIndividuals;

            this.TransmissionCoefficientModificationFactorAsymptomaticIndividuals = transmissionCoefficientModificationFactorAsymptomaticIndividuals;

            this.TransmissionCoefficientModificationFactorIsolatedIndividuals = transmissionCoefficientModificationFactorIsolatedIndividuals;

            this.TransmissionCoefficientModificationFactorQuarantinedIndividuals = transmissionCoefficientModificationFactorQuarantinedIndividuals;

            this.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals = developmentClinicalSymptomsRateAsymptomaticIndividuals;

            this.DevelopmentClinicalSymptomsRateQuarantinedIndividuals = developmentClinicalSymptomsRateQuarantinedIndividuals;

            this.NaturalDeathRate = naturalDeathRate;
        }

        /// <summary>
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// </summary>
        public double DiseaseInducedDeathRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// Parameter: d_2
        /// </summary>
        public double DiseaseInducedDeathRateIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// Parameter: p
        /// </summary>
        public double RecruitmentRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the basic reproduction number.
        /// Parameter: ℛ_0
        /// </summary>
        public double BasicReproductionNumber { get; }

        /// <summary>
        /// Gets the control reproduction number.
        /// Parameter: ℛ_c
        /// </summary>
        public double ControlReproductionNumber { get; }

        /// <summary>
        /// Gets the basic transmission coefficient.
        /// Parameter: β
        /// </summary>
        public double BasicTransmissionCoefficient { get; }

        /// <summary>
        /// Gets the quarantine rate for asymptomatic individuals.
        /// Parameter: γ_1
        /// </summary>
        public double QuarantineRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// Parameter: γ_2
        /// </summary>
        public double IsolationRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for asymptomatic individuals.
        /// Parameter: ε_E
        /// </summary>
        public double TransmissionCoefficientModificationFactorAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// Parameter: ε_J
        /// </summary>
        public double TransmissionCoefficientModificationFactorIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// Parameter: ε_Q
        /// </summary>
        public double TransmissionCoefficientModificationFactorQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// Parameter: κ_1
        /// </summary>
        public double DevelopmentClinicalSymptomsRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// Parameter: κ_2
        /// </summary>
        public double DevelopmentClinicalSymptomsRateQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// </summary>
        public double NaturalDeathRate { get; }
    }
}