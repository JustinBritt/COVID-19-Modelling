﻿namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals
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
        /// Gets the recovery rate for symptomatic individuals.
        /// </summary>
        FhirDecimal Value { get; }
    }
}