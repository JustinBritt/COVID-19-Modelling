﻿namespace C19M.M.C.Gumel2004.Classes.Variables.TotalPopulationSize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Variables.TotalPopulationSize;

    internal sealed class N : IN
    {
        private ILog Log { get; }

        // Constructor
        public N()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}