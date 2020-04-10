namespace C19M.M.C.Gumel2004.Classes.Variables.IsolatedIndividuals
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

    using C19M.M.C.Gumel2004.Interfaces.Variables.IsolatedIndividuals;

    internal sealed class J : IJ
    {
        private ILog Log { get; }

        // Constructor
        public J()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}