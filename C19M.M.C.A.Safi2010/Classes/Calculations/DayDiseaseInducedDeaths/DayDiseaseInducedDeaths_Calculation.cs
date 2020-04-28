namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayDiseaseInducedDeaths;

    internal sealed class DayDiseaseInducedDeaths_Calculation : IDayDiseaseInducedDeaths_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}