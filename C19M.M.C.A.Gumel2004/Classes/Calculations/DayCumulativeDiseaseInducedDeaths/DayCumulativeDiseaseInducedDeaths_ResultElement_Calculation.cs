namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths;

    internal sealed class DayCumulativeDiseaseInducedDeaths_ResultElement_Calculation : IDayCumulativeDiseaseInducedDeaths_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeDiseaseInducedDeaths_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public IDayCumulativeDiseaseInducedDeaths_ResultElement Calculate(
            DateTime t_IndexElement,
            It t,
            IDayDiseaseInducedDeaths dayDiseaseInducedDeaths)
        {
            double value = 0;

            for (DateTime i = t.StartDate; i <= t_IndexElement; i = i.AddDays(1))
            {
                value += dayDiseaseInducedDeaths.GetElementAt(
                    i);
            }

            return new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayCumulativeDiseaseInducedDeaths.DayCumulativeDiseaseInducedDeaths_ResultElement(
                t_IndexElement,
                value);
        }
    }
}