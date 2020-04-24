namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals
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
        /// Gets the disease-induced death rate for hospitalized individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}