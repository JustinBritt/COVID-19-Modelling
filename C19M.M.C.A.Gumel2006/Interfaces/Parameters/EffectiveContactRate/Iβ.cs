namespace C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iβ
    {
        /// <summary>
        /// Gets the effective contact rate.
        /// </summary>
        FhirDecimal Value { get; }
    }
}