﻿namespace C19M.M.C.A.Gumel2006.Interfaces.Parameters.EquilibriumPopulationWithoutDisease
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IN
    {
        /// <summary>
        /// Gets the equilibrium population (without disease).
        /// </summary>
        FhirDecimal Value { get; }
    }
}