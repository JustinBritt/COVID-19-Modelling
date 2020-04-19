﻿namespace C19M.M.C.A.Gumel2004.Classes.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals
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

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals;

    internal sealed class ε : Iε
    {
        private ILog Log { get; }

        // Constructor
        public ε(
            Func<DateTime, FhirDecimal> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// </summary>
        public Func<DateTime, FhirDecimal> Value { get; }
    }
}