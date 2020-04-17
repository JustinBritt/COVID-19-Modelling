namespace C19M.M.C.A.Gumel2004.Classes.Results.DiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DiseaseInducedDeaths;

    internal sealed class DiseaseInducedDeaths : IDiseaseInducedDeaths
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseInducedDeaths(
            ImmutableList<IDiseaseInducedDeaths_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IDiseaseInducedDeaths_ResultElement> Value { get; }
    }
}