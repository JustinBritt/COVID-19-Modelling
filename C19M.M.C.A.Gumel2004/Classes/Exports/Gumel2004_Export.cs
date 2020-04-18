namespace C19M.M.C.A.Gumel2004.Classes.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Exports;

    using C19M.M.C.A.Gumel2004.Interfaces.Models;

    using C19M.M.C.A.Gumel2004.Interfaces.Solutions;

    public sealed class Gumel2004_Export : IGumel2004_Export
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Export()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public ImmutableList<Tuple<DateTime, double>> DayCumulativeDiseaseInducedDeaths { get; private set; }
    }
}