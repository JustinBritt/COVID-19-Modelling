namespace C19M.D.Gumel2006.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.D.Gumel2006.Interfaces;

    /// <summary>
    /// Represents data from the Greater Toronto Area (GTA).
    /// </summary>
    public sealed class GreaterTorontoArea : IGreaterTorontoArea
    {
        private ILog Log { get; }

        // Constructor
        public GreaterTorontoArea()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Gets the disease-induced mortality rate.
        /// Parameter: d
        /// Units: Per day
        /// </summary>
        public double DiseaseInducedMortalityRate => 0.008;

        /// <summary>
        /// Gets the equilibrium population (without disease).
        /// Parameter: N_o
        /// </summary>
        public double EquilibriumPopulationWithoutDisease => 4000000;

        /// <summary>
        /// Gets the rate of development of clinical symptoms.
        /// Parameter: α
        /// Units: Per day
        /// </summary>
        public double DevelopmentClinicalSymptomsRate => 0.125;

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// Units: Per day
        /// </summary>
        public double EffectiveContactRate => 7.2e-8;

        /// <summary>
        /// Gets the recovery rate.
        /// Parameter: δ
        /// Units: Per day
        /// </summary>
        public double RecoveryRate => 0.04;

        /// <summary>
        /// Gets the natural mortality rate.
        /// Parameter: μ
        /// Units: Per day
        /// </summary>
        public double NaturalMortalityRate => 3.65e-5;

        /// <summary>
        /// Gets the vaccination coverage rate.
        /// Parameter: ξ
        /// Units: Per day
        /// </summary>
        public double VaccinationCoverageRate => 0.14;

        /// <summary>
        /// Gets the recruitment rate of susceptible humans.
        /// Parameter: Π
        /// Units: Per day
        /// </summary>
        public double RecruitmentRateSusceptibleHumans => 146;

        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// Parameter: τ
        /// </summary>
        public double VaccineEfficacy => 0.8;
    }
}