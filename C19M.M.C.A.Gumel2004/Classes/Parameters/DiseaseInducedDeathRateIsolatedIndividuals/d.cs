namespace C19M.M.C.A.Gumel2004.Classes.Parameters.DiseaseInducedDeathRateIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals;

    internal sealed class d : Id
    {
        private ILog Log { get; }

        // Constructor
        public d(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// </summary>
        public double Value { get; }
    }
}