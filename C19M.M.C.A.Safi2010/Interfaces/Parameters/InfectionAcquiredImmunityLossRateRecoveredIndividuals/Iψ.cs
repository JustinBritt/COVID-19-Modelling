namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iψ
    {
        /// <summary>
        /// Gets the rate at which recovered individuals lose their infection-acquired immunity.
        /// </summary>
        FhirDecimal Value { get; }
    }
}