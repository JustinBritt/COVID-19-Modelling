namespace C19M.M.C.Gumel2004.Classes.Parameters.RecoveryRateSymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals;

    internal class σ : Iσ
    {
        private ILog Log { get; }

        // Constructor
        public σ(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the recovery rate for symptomatic individuals.
        /// </summary>
        public double Value { get; }
    }
}