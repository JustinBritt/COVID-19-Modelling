namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iη
    {
        /// <summary>
        /// Gets the efficacy of isolation or treatment given to hospitalized individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}