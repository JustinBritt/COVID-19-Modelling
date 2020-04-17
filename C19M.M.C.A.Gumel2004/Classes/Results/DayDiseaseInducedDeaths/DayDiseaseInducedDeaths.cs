namespace C19M.M.C.A.Gumel2004.Classes.Results.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths;

    internal sealed class DayDiseaseInducedDeaths : IDayDiseaseInducedDeaths
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths(
            ImmutableList<IDayDiseaseInducedDeaths_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IDayDiseaseInducedDeaths_ResultElement> Value { get; }
    }
}