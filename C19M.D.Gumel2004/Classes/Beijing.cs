namespace C19M.D.Gumel2004.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.D.Gumel2004.Interfaces;

    /// <summary>
    /// Represents data from Beijing.
    /// </summary>
    internal sealed class Beijing : IBeijing
    {
        private ILog Log { get; }

        // Constructor
        public Beijing()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        public DateTime StartDate => new DateTime(2003, 2, 15);

        /// <summary>
        /// Gets the start date for isolation and quarantine programs.
        /// </summary>
        public DateTime IsolationQuarantineStartDate => new DateTime(2003, 3, 30);

        /// <summary>
        /// Gets the start date for perfect isolation.
        /// </summary>
        public DateTime PerfectIsolationStartDate => new DateTime(2003, 4, 20);

        /// <summary>
        /// Gets the end date.
        /// </summary>
        public DateTime EndDate => new DateTime(2003, 9, 1);

        /// <summary>
        /// Gets the number of days after the start date for some other date.
        /// </summary>
        public Func<DateTime, int> NumberDaysAfterStartDate =>
            (x) =>
            {
                if (x.Date >= this.StartDate)
                {
                    return (int)Math.Abs(Math.Round((x - this.StartDate).TotalDays));
                }
                else
                {
                    return 0;
                }
            };

        /// <summary>
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// </summary>
        public double DiseaseInducedDeathRateSymptomaticIndividuals => 0.0055;

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// Parameter: d_2
        /// </summary>
        public double DiseaseInducedDeathRateIsolatedIndividuals => 0.0041;

        /// <summary>
        /// Gets the initial value for asymptomatic individuals.
        /// Parameter: E(0)
        /// </summary>
        public double InitialValueAsymptomaticIndividuals => 10;

        /// <summary>
        /// Gets the initial value for symptomatic individuals.
        /// Parameter: I(0)
        /// </summary>
        public double InitialValueSymptomaticIndividuals => 3;

        /// <summary>
        /// Gets the initial value for isolated individuals.
        /// Parameter: J(0)
        /// </summary>
        public double InitialValueIsolatedIndividuals => 0;

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// Parameter: p
        /// </summary>
        public double RecruitmentRateAsymptomaticIndividuals => 0;

        /// <summary>
        /// Gets the initial value for quarantined individuals.
        /// Parameter: Q(0)
        /// </summary>
        public double InitialValueQuarantinedIndividuals => 0;

        /// <summary>
        /// Gets the initial value for recovered individuals.
        /// Parameter: R(0)
        /// </summary>
        public double InitialValueRecoveredIndividuals => 0;

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        public double InitialValueSusceptibleIndividuals => 12000000;

        /// <summary>
        /// Gets the basic transmission coefficient.
        /// Parameter: β
        /// </summary>
        public double BasicTransmissionCoefficient => 0.23;

        /// <summary>
        /// Gets the quarantine rate for asymptomatic individuals.
        /// Parameter: γ_1
        /// </summary>
        public Func<DateTime, double> QuarantineRateAsymptomaticIndividuals =>
            (x) =>
            {
                if (x.Date <= this.IsolationQuarantineStartDate)
                {
                    return 0;
                }
                else
                {
                    return 0.1;
                }
            };

        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// Parameter: γ_2
        /// </summary>
        public Func<DateTime, double> IsolationRateSymptomaticIndividuals =>
            (x) =>
            {
                if (x.Date <= this.IsolationQuarantineStartDate)
                {
                    return 0;
                }
                else
                {
                    return 0.5;
                }
            };

        /// <summary>
        /// Gets the transmission coefficient modification factor for asymptomatic individuals.
        /// Parameter: ε_E
        /// </summary>
        public double TransmissionCoefficientModificationFactorAsymptomaticIndividuals => 0;

        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// Parameter: ε_J
        /// </summary>
        public Func<DateTime, double> TransmissionCoefficientModificationFactorIsolatedIndividuals =>
            (x) =>
            {
                if (x.Date <= this.PerfectIsolationStartDate)
                {
                    return 0.82;
                }
                else
                {
                    return 0;
                }
            };

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// Parameter: ε_Q
        /// </summary>
        public Func<DateTime, double> TransmissionCoefficientModificationFactorQuarantinedIndividuals =>
            (x) =>
            {
                return 0;
            };

        /// <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// Parameter: κ_1
        /// </summary>
        public double DevelopmentClinicalSymptomsRateAsymptomaticIndividuals => 0.1; // Not clear if Beijing has the same value as the other three cities

        /// <summary>
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// Parameter: κ_2
        /// </summary>
        public double DevelopmentClinicalSymptomsRateQuarantinedIndividuals => 0.125; // Not clear if Beijing has the same value as the other three cities

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// </summary>
        public double NaturalDeathRate => 0.000034; // Not clear if Beijing has the same value as the other three cities

        /// <summary>
        /// Gets the net inflow rate of susceptible individuals per unit time.
        /// Parameter: Π
        /// </summary>
        public double NetInflowRateSusceptibleIndividuals => 408;

        /// <summary>
        /// Gets the recovery rate for symptomatic individuals.
        /// Parameter: σ_1
        /// </summary>
        public double RecoveryRateSymptomaticIndividuals => 0.0413;

        /// <summary>
        /// Gets the recovery rate for isolated individuals.
        /// Parameter: σ_2
        /// </summary>
        public double RecoveryRateIsolatedIndividuals => 0.0431;
    }
}