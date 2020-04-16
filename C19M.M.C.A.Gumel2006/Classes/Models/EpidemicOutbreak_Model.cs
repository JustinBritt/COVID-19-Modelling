namespace C19M.M.C.A.Gumel2006.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Models;

    internal sealed class EpidemicOutbreak_Model : IEpidemicOutbreak_Model
    {
        private ILog Log { get; }

        // Constructor
        public EpidemicOutbreak_Model(
            IGumel2006_Context context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // Variables

            // E(t)

            // I(t)

            // N(t)

            // R(t)

            // S(t)

            // V(t)
        }
    }
}