namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iϕ
    {
        /// <summary>
        /// Gets the hospitalization rate for infectious individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}