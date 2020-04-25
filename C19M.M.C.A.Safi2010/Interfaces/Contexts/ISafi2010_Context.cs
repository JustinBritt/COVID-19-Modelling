namespace C19M.M.C.A.Safi2010.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    public interface ISafi2010_Context
    {
        /// <summary>
        /// Gets the hospitalization rate for quarantined individuals.
        /// Parameter: α
        /// </summary>
        FhirDecimal HospitalizationRateQuarantinedIndividuals { get; }

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// </summary>
        FhirDecimal EffectiveContactRate { get; }
    }
}