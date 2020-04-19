namespace C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iδ
    {
        /// <summary>
        /// Gets the recovery rate.
        /// </summary>
        FhirDecimal Value { get; }
    }
}