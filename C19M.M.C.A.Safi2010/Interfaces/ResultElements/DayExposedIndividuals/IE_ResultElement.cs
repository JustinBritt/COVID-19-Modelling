namespace C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IE_ResultElement
    {
        FhirDateTime t_IndexElement { get; }

        FhirDecimal Value { get; }
    }
}