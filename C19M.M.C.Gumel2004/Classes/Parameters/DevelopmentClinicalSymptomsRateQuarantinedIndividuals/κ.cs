namespace C19M.M.C.Gumel2004.Classes.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals;

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
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// </summary>
        public double Value { get; }
    }
}