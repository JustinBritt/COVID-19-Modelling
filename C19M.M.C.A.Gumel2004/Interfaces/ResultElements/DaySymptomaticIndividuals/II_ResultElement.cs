namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface II_ResultElement
    {
        DateTime t_IndexElement { get; }

        FhirDecimal Value { get; }
    }
}