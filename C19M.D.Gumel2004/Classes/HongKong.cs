namespace C19M.D.Gumel2004.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.D.Gumel2004.Interfaces;

    /// <summary>
    /// Represents data from Hong Kong.
    /// </summary>
    public sealed class HongKong : IHongKong
    {
        private ILog Log { get; }

        public HongKong()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        public FhirDateTime StartDate => new FhirDateTime(new DateTimeOffset(new DateTime(2003, 3, 1)));

        /// <summary>
        /// Gets the start date for isolation and quarantine programs.
        /// </summary>
        public FhirDateTime IsolationQuarantineStartDate => new FhirDateTime(new DateTimeOffset(new DateTime(2003, 3, 30)));

        /// <summary>
        /// Gets the start date for perfect isolation.
        /// </summary>
        public FhirDateTime PerfectIsolationStartDate => new FhirDateTime(new DateTimeOffset(new DateTime(2003, 4, 20)));

        /// <summary>
        /// Gets the end date.
        /// </summary>
        public FhirDateTime EndDate => new FhirDateTime(new DateTimeOffset(new DateTime(2003, 9, 1)));

        /// <summary>
        /// Gets the number of days after the start date for some other date.
        /// </summary>
        public Func<FhirDateTime, PositiveInt> NumberDaysAfterStartDate =>
            (x) =>
            {
                if (x.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date >= this.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                {
                    return new PositiveInt((int)Math.Abs(Math.Round((x.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date - this.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date).TotalDays)));
                }
                else
                {
                    return new PositiveInt(0);
                }
            };

        /// <summary>
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// Units: Per day
        /// </summary>
        public FhirDecimal DiseaseInducedDeathRateSymptomaticIndividuals => new FhirDecimal(0.0079m);

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// Parameter: d_2
        /// Units: Per day
        /// </summary>
        public FhirDecimal DiseaseInducedDeathRateIsolatedIndividuals => new FhirDecimal(0.0068m);

        /// <summary>
        /// Gets the initial value for asymptomatic individuals.
        /// Parameter: E(0)
        /// </summary>
        public FhirDecimal InitialValueAsymptomaticIndividuals => new FhirDecimal(124m);

        /// <summary>
        /// Gets the initial value for symptomatic individuals.
        /// Parameter: I(0)
        /// </summary>
        public FhirDecimal InitialValueSymptomaticIndividuals => new FhirDecimal(1m);

        /// <summary>
        /// Gets the initial value for isolated individuals.
        /// Parameter: J(0)
        /// </summary>
        public FhirDecimal InitialValueIsolatedIndividuals => new FhirDecimal(0m);

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// Parameter: p
        /// Units: Per day
        /// </summary>
        public FhirDecimal RecruitmentRateAsymptomaticIndividuals => new FhirDecimal(0m);

        /// <summary>
        /// Gets the initial value for quarantined individuals.
        /// Parameter: Q(0)
        /// </summary>
        public FhirDecimal InitialValueQuarantinedIndividuals => new FhirDecimal(0m);

        /// <summary>
        /// Gets the initial value for recovered individuals.
        /// Parameter: R(0)
        /// </summary>
        public FhirDecimal InitialValueRecoveredIndividuals => new FhirDecimal(0m);

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// Parameter: S(0)
        /// </summary>
        public FhirDecimal InitialValueSusceptibleIndividuals => new FhirDecimal(6500000m);

        /// <summary>
        /// Gets the basic transmission coefficient.
        /// Parameter: β
        /// </summary>
        public FhirDecimal BasicTransmissionCoefficient => new FhirDecimal(0.15m);

        /// <summary>
        /// Gets the quarantine rate for asymptomatic individuals.
        /// Parameter: γ_1
        /// Units: Per day
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> QuarantineRateAsymptomaticIndividuals =>
            (x) =>
            {
                if (x.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date <= this.IsolationQuarantineStartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                {
                    return new FhirDecimal(0m);
                }
                else
                {
                    return new FhirDecimal(0.1m);
                }
            };

        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// Parameter: γ_2
        /// Units: Per day
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> IsolationRateSymptomaticIndividuals =>
            (x) =>
            {
                if (x.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date <= this.IsolationQuarantineStartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                {
                    return new FhirDecimal(0m);
                }
                else
                {
                    return new FhirDecimal(0.5m);
                }
            };

        /// <summary>
        /// Gets the transmission coefficient modification factor for asymptomatic individuals.
        /// Parameter: ε_E
        /// </summary>
        public FhirDecimal TransmissionCoefficientModificationFactorAsymptomaticIndividuals => new FhirDecimal(0m);

        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// Parameter: ε_J
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> TransmissionCoefficientModificationFactorIsolatedIndividuals =>
            (x) =>
            {
                if (x.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date <= this.PerfectIsolationStartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                {
                    return new FhirDecimal(0.84m);
                }
                else
                {
                    return new FhirDecimal(0m);
                }
            };

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// Parameter: ε_Q
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> TransmissionCoefficientModificationFactorQuarantinedIndividuals =>
            (x) =>
            {
                return new FhirDecimal(0m);
            };

        /// <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// Parameter: κ_1
        /// Units: Per day
        /// </summary>
        public FhirDecimal DevelopmentClinicalSymptomsRateAsymptomaticIndividuals => new FhirDecimal(0.1m);

        /// <summary>
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// Parameter: κ_2
        /// Units: Per day
        /// </summary>
        public FhirDecimal DevelopmentClinicalSymptomsRateQuarantinedIndividuals => new FhirDecimal(0.125m);

        /// <summary>
        /// Gets the natural death rate.
        /// Parameter: μ
        /// Units: Per day
        /// </summary>
        public FhirDecimal NaturalDeathRate => new FhirDecimal(0.000034m);

        /// <summary>
        /// Gets the net inflow rate of susceptible individuals per unit time.
        /// Parameter: Π
        /// Units: Per day
        /// </summary>
        public FhirDecimal NetInflowRateSusceptibleIndividuals => new FhirDecimal(221m);

        /// <summary>
        /// Gets the recovery rate for symptomatic individuals.
        /// Parameter: σ_1
        /// Units: Per day
        /// </summary>
        public FhirDecimal RecoveryRateSymptomaticIndividuals => new FhirDecimal(0.0337m);

        /// <summary>
        /// Gets the recovery rate for isolated individuals.
        /// Parameter: σ_2
        /// Units: Per day
        /// </summary>
        public FhirDecimal RecoveryRateIsolatedIndividuals => new FhirDecimal(0.0386m);
    }
}