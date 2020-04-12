namespace C19M.D.Gumel2004.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.D.Gumel2004.Interfaces;

    /// <summary>
    /// Represents data from the Greater Toronto Area (GTA).
    /// </summary>
    public sealed class GTA : IGTA
    {
        private ILog Log { get; }

        // Constructor
        public GTA()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}