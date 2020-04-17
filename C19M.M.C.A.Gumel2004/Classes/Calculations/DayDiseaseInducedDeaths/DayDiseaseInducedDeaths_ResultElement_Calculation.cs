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

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    internal sealed class DayDiseaseInducedDeaths_ResultElement_Calculation : IDayDiseaseInducedDeaths_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public IDayDiseaseInducedDeaths_ResultElement Calculate(
            DateTime t_IndexElement,
            It t,
            II I,
            IJ J)
        {
            return new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_ResultElement(
                t_IndexElement,
                d_1.Value * I.Value.Where(w => w.t_IndexElement == t_IndexElement).Select(w => w.Value).SingleOrDefault() + d_2.Value * J.Value.Where(w => w.t_IndexElement == t_IndexElement).Select(w => w.Value).SingleOrDefault());
        }
    }
}