namespace C19M.M.C.Gumel2004.Classes.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Exports;

    public sealed class Gumel2004_Export : IGumel2004_Export
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Export()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}