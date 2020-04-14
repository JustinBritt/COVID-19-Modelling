namespace C19M.M.C.A.Gumel2006.Classes.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals;

    internal sealed class α : Iα
    {
        private ILog Log { get; }

        // Constructor
        public α(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the rate of development of clinical symptoms.
        /// </summary>
        public double Value { get; }
    }
}