namespace C19M.M.C.A.Safi2010.Interfaces.Variables.ExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IE
    {
        FhirDecimal InitialValue { get; }
    }
}