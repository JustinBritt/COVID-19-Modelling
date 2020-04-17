namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IDiseaseInducedDeaths_ResultElement
    {
        DateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the number of disease-induced deaths.
        /// </summary>
        double Value { get; }
    }
}