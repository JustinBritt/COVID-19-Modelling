namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DiseaseInducedDeaths;

    internal sealed class DiseaseInducedDeaths_ResultElement_Calculation : IDiseaseInducedDeaths_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseInducedDeaths_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public IDiseaseInducedDeaths_ResultElement Calculate()
        {
            throw new NotImplementedException();
        }
    }
}