namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iγ
    {
        /// <summary>
        /// Gets the natural recovery rate for infectious individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}