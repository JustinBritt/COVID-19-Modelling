namespace C19M.M.C.A.Gumel2004.Interfaces.Variables.TotalPopulationSize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IN
    {
        FhirDecimal InitialValue { get; }
    }
}