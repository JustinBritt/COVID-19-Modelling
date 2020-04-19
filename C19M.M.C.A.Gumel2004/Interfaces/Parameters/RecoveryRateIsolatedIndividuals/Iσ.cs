namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals
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
        /// Gets the recovery rate for isolated individuals.
        /// </summary>
        double Value { get; }
    }
}