﻿namespace C19M.M.C.A.Gumel2006.Classes.Parameters.EffectiveContactRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate;

    internal sealed class β : Iβ
    {
        private ILog Log { get; }

        // Constructor
        public β(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the effective contact rate.
        /// </summary>
        public double Value { get; }
    }
}