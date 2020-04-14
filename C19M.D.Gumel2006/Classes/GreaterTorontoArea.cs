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
        /// </summary>
        public double DiseaseInducedDeathRate => 0.008;

        /// <summary>
        /// Gets the rate of development of clinical symptoms
        /// Parameter: α
        /// </summary>
        public double DevelopmentClinicalSymptomsRateAsymptomaticIndividuals => 0.125;

        /// <summary>
        /// Gets the recovery rate.
        /// Parameter: δ
        /// </summary>
        public double RecoveryRate => 0.04;

        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// Parameter: τ
        /// </summary>
        public double VaccineEfficacy => 0.8;
    }
}