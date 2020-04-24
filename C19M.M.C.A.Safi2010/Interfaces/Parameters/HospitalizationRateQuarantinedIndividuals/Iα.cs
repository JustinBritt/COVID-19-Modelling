namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iα
    {
        /// <summary>
        /// Gets the hospitalization rate for quarantined individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}