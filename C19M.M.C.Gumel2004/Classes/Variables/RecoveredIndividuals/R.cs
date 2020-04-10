namespace C19M.M.C.Gumel2004.Classes.Variables.RecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Oslo
    using Microsoft.Research.Oslo;

    using C19M.M.C.Gumel2004.Interfaces.Variables.RecoveredIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        // Constructor
        public R(
            Vector value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public Vector Value { get; }
    }
}