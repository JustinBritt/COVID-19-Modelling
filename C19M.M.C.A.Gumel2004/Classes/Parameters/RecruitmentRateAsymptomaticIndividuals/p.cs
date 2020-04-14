namespace C19M.M.C.A.Gumel2004.Classes.Parameters.RecruitmentRateAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecruitmentRateAsymptomaticIndividuals;

    internal sealed class p : Ip
    {
        private ILog Log { get; }

        // Constructor
        public p(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// </summary>
        public double Value { get; }
    }
}