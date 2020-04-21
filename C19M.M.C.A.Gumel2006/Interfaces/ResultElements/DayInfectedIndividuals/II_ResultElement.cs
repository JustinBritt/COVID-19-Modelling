namespace C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayInfectedIndividuals
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
        FhirDateTime t_IndexElement { get; }

        FhirDecimal Value { get; }
    }
}