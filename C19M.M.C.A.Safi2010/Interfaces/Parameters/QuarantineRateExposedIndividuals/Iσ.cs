namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iσ
    {
        /// <summary>
        /// Gets the quarantine rate for exposed individuals;
        /// </summary>
        FhirDecimal Value { get; }
    }
}