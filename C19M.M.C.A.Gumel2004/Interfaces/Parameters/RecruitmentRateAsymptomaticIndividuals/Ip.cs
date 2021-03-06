﻿namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecruitmentRateAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Ip
    {
        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// </summary>
        FhirDecimal Value { get; }
    }
}