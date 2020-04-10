namespace C19M.M.C.Gumel2004.Classes.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals;

    internal sealed class κ : Iκ
    {
        private ILog Log { get; }

        // Constructor
        public κ(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// </summary>
        public double Value { get; }
    }
}