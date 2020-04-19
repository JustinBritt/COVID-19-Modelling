namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IDayDiseaseInducedDeaths_ResultElement
    {
        FhirDateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the number of disease-induced deaths.
        /// </summary>
        FhirDecimal Value { get; }
    }
}