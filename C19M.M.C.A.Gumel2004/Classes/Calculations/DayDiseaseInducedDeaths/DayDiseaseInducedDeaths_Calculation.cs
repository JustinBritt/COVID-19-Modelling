namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths;

    internal sealed class DayDiseaseInducedDeaths_Calculation : IDayDiseaseInducedDeaths_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public IDayDiseaseInducedDeaths Calculate()
        {
            throw new NotImplementedException();
        }
    }
}