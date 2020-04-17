﻿namespace C19M.M.C.A.Gumel2004.Classes.Results.DaySymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    internal sealed class I : II
    {
        private ILog Log { get; }

        // Constructor
        public I(
            ImmutableList<II_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<II_ResultElement> Value { get; }
    }
}