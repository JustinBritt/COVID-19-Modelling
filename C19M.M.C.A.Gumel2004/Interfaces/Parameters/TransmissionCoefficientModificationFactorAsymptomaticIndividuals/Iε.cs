namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iε
    {
        /// <summary>
        /// Gets the transmission coefficient modification factor for asymptomatic individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}