﻿namespace C19M.M.C.A.Gumel2004.Classes.Parameters.RecoveryRateIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals;

    internal sealed class σ : Iσ
    {
        private ILog Log { get; }

        // Constructor
        public σ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the recovery rate for isolated individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}