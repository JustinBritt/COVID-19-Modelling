namespace C19M.M.C.A.Safi2010.Interfaces.Results.DayQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IQ
    {
        decimal GetElementAtAsdecimal(
            FhirDateTime t_IndexElement);
    }
}