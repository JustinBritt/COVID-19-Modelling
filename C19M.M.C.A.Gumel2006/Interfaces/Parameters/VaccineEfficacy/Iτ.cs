namespace C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iτ
    {
        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// </summary>
        FhirDecimal Value { get; }
    }
}