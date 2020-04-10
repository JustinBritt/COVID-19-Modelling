namespace C19M.M.C.Gumel2004.Classes.Variables.SymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Variables.SymptomaticIndividuals;

    internal sealed class I : II
    {
        private ILog Log { get; }

        // Constructor
        public I()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}