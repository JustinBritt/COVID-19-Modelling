﻿namespace C19M.M.C.A.Gumel2004.Classes.ResultElements.DayQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayQuarantinedIndividuals;

    internal sealed class Q_ResultElement : IQ_ResultElement
    {
        private ILog Log { get; }

        // Constructor
        public Q_ResultElement(
            DateTime t_IndexElement,
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.t_IndexElement = t_IndexElement;

            this.Value = value;
        }

        public DateTime t_IndexElement { get; }

        public double Value { get; }
    }
}