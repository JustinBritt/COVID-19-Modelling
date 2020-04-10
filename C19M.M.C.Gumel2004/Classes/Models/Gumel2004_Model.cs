namespace C19M.M.C.Gumel2004.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Models;

    internal sealed class Gumel2004_Model : IGumel2004_Model
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Model(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}