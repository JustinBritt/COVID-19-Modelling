namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IDayCumulativeDiseaseInducedDeaths_ResultElement
    {
        DateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the cumulative number of disease-induced deaths.
        /// </summary>
        double Value { get; }
    }
}