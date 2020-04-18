namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths;

    internal sealed class DayCumulativeDiseaseInducedDeaths_Calculation : IDayCumulativeDiseaseInducedDeaths_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeDiseaseInducedDeaths_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayCumulativeDiseaseInducedDeaths Calculate(
            It t,
            IDayDiseaseInducedDeaths dayDiseaseInducedDeaths)
        {
            return new C19M.M.C.A.Gumel2004.Classes.Results.DayCumulativeDiseaseInducedDeaths.DayCumulativeDiseaseInducedDeaths(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeDiseaseInducedDeaths.DayCumulativeDiseaseInducedDeaths_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        dayDiseaseInducedDeaths))
                .ToImmutableList());
        }
    }
}