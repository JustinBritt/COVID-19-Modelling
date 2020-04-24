namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IΠ
    {
        /// <summary>
        /// Gets the recruitment rate of susceptible individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}