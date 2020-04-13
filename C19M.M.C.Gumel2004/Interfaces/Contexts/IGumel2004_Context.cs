﻿namespace C19M.M.C.Gumel2004.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGumel2004_Context
    {
        /// <summary>
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// </summary>
        double DiseaseInducedDeathRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// Parameter: d_2
        /// </summary>
        double DiseaseInducedDeathRateIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for asymptomatic individuals.
        /// Parameter: E(0)
        /// </summary>
        double InitialValueAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for symptomatic individuals.
        /// Parameter: I(0)
        /// </summary>
        double InitialValueSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for isolated individuals.
        /// Parameter: J(0)
        /// </summary>
        double InitialValueIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// Parameter: p
        /// </summary>
        double RecruitmentRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the initial value for quarantined individuals.
        /// Parameter: Q(0)
        /// </summary>
        double InitialValueQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the initial value for recovered individuals.
        /// Parameter: R(0)
        /// </summary>
        double InitialValueRecoveredIndividuals { get; }

        /// <summary>
        /// Gets the basic reproduction number.
        /// Parameter: ℛ_0
        /// </summary>
        double BasicReproductionNumber { get; }

        /// <summary>
        /// Gets the control reproduction number.
        /// Parameter: ℛ_c
        /// </summary>
        double ControlReproductionNumber { get; }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        double InitialValueSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the basic transmission coefficient.
        /// Parameter: β
        /// </summary>
        double BasicTransmissionCoefficient { get; }

        /// <summary>
        /// Gets the quarantine rate for asymptomatic individuals.
        /// Parameter: γ_1
        /// </summary>
        Func<DateTime, double> QuarantineRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// Parameter: γ_2
        /// </summary>
        Func<DateTime, double> IsolationRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for asymptomatic individuals.
        /// Parameter: ε_E
        /// </summary>
        double TransmissionCoefficientModificationFactorAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// Parameter: ε_J
        /// </summary>
        Func<DateTime, double> TransmissionCoefficientModificationFactorIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// Parameter: ε_Q
        /// </summary>
        double TransmissionCoefficientModificationFactorQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// Parameter: κ_1
        /// </summary>
        double DevelopmentClinicalSymptomsRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// Parameter: κ_2
        /// </summary>
        double DevelopmentClinicalSymptomsRateQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// </summary>
        double NaturalDeathRate { get; }

        /// <summary>
        /// Gets the net inflow rate of susceptible individuals per unit time.
        /// Parameter: Π
        /// </summary>
        double NetInflowRateSusceptibleIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for symptomatic individuals.
        /// Parameter: σ_1
        /// </summary>
        double RecoveryRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the recovery rate for isolated individuals.
        /// Parameter: σ_2
        /// </summary>
        double RecoveryRateIsolatedIndividuals { get; }
    }
}