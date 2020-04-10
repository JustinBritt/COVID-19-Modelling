namespace C19M.M.C.Gumel2004.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IGumel2004_Context
    {
        /// <summary>
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// </summary>
        double DiseaseInducedDeathRateSymptomaticIndividuals { get; }
    }
}