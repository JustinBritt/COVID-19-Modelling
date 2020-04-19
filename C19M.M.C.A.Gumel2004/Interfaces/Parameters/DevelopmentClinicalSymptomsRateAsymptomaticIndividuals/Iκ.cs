namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iκ
    {
        // <summary>
        /// Gets the rate at which asymptomatic individuals develop clinical symptoms.
        /// </summary>
        double Value { get; }
    }
}