namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IQ_ResultElement
    {
        DateTime t_IndexElement { get; }

        FhirDecimal Value { get; }
    }
}