namespace C19M.M.C.A.Gumel2004.Classes.Results.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;

    internal sealed class DayCumulativeDiseaseInducedDeaths : IDayCumulativeDiseaseInducedDeaths
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeDiseaseInducedDeaths(
            ImmutableList<IDayCumulativeDiseaseInducedDeaths_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IDayCumulativeDiseaseInducedDeaths_ResultElement> Value { get; }
    }
}