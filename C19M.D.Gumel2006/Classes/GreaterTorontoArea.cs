﻿namespace C19M.D.Gumel2006.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.D.Gumel2006.Interfaces;

    /// <summary>
    /// Represents data from the Greater Toronto Area (GTA).
    /// </summary>
    public sealed class GreaterTorontoArea : IGreaterTorontoArea
    {
        private ILog Log { get; }

        // Constructor
        public GreaterTorontoArea()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}