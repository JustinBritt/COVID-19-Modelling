﻿namespace C19M.M.C.A.Safi2010.Classes.ResultElements.DayCumulativeProbableCases
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

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayCumulativeProbableCases;

    internal sealed class DayCumulativeProbableCases_ResultElement : IDayCumulativeProbableCases_ResultElement
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeProbableCases_ResultElement(
            FhirDateTime t_IndexElement,
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.t_IndexElement = t_IndexElement;

            this.Value = value;
        }

        public FhirDateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the cumulative number of probable cases.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}