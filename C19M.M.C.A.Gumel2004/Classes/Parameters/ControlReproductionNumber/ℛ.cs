﻿namespace C19M.M.C.A.Gumel2004.Classes.Parameters.ControlReproductionNumber
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

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.ControlReproductionNumber;

    internal sealed class ℛ : Iℛ
    {
        private ILog Log { get; }

        // Constructor
        public ℛ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the control reproduction number.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}