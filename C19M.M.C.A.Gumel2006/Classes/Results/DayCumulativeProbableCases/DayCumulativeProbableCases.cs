﻿namespace C19M.M.C.A.Gumel2006.Classes.Results.DayCumulativeProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeProbableCases;

    internal sealed class DayCumulativeProbableCases : IDayCumulativeProbableCases
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeProbableCases(
            ImmutableList<IDayCumulativeProbableCases_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IDayCumulativeProbableCases_ResultElement> Value { get; }
    }
}