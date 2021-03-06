﻿namespace C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iα
    {
        /// <summary>
        /// Gets the rate of development of clinical symptoms.
        /// </summary>
        FhirDecimal Value { get; }
    }
}