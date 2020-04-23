namespace C19M.M.C.A.Safi2010.Interfaces.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IQ
    {
        FhirDecimal InitialValue { get; }
    }
}