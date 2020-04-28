namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayCumulativeDiseaseInducedDeaths
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

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayCumulativeDiseaseInducedDeaths;

    internal sealed class DayCumulativeDiseaseInducedDeaths_Calculation : IDayCumulativeDiseaseInducedDeaths_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeDiseaseInducedDeaths_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}