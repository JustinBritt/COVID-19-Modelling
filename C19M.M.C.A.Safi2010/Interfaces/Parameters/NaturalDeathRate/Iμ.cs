namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate
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
        /// Gets the natural death rate.
        /// </summary>
        FhirDecimal Value { get; }
    }
}