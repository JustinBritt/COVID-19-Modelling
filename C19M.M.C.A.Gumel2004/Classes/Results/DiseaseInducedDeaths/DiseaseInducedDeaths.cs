namespace C19M.M.C.A.Gumel2004.Classes.Results.DiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DiseaseInducedDeaths;

    internal sealed class DiseaseInducedDeaths : IDiseaseInducedDeaths
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseInducedDeaths(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the number of disease-induced deaths.
        /// </summary>
        public double Value { get; }
    }
}