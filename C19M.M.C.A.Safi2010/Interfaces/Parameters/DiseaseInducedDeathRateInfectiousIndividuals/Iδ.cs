namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals
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
        /// Gets the disease-induced death rate for infectious individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}