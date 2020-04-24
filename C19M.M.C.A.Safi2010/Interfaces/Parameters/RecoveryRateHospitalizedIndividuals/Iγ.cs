namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals
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
        /// Gets the recovery rate for hospitalized individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}