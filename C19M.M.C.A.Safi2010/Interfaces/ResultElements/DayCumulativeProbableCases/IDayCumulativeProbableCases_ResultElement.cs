﻿namespace C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayCumulativeProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IDayCumulativeProbableCases_ResultElement
    {
        FhirDateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the cumulative number of probable cases.
        /// </summary>
        FhirDecimal Value { get; }
    }
}