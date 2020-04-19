namespace C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iμ
    {
        /// <summary>
        /// Gets the natural mortality rate.
        /// </summary>
        FhirDecimal Value { get; }
    }
}