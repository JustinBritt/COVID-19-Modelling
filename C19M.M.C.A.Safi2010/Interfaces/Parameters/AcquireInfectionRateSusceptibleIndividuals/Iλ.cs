namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iλ
    {
        /// <summary>
        /// Gets the rate at which susceptible individuals acquire infections.
        /// </summary>
        FhirDecimal Value { get; }
    }
}