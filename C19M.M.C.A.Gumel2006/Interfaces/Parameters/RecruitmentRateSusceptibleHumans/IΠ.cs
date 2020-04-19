namespace C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans
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
        /// Gets the recruitment rate of susceptible humans.
        /// </summary>
        FhirDecimal Value { get; }
    }
}