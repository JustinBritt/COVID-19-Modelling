﻿namespace C19M.M.C.A.Gumel2004.Classes.ResultElements.DiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DiseaseInducedDeaths;

    internal sealed class DiseaseInducedDeaths_ResultElement : IDiseaseInducedDeaths_ResultElement
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseInducedDeaths_ResultElement(
            DateTime t_IndexElement,
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.t_IndexElement = t_IndexElement;

            this.Value = value;
        }

        public DateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the number of disease-induced deaths.
        /// </summary>
        public double Value { get; }
    }
}