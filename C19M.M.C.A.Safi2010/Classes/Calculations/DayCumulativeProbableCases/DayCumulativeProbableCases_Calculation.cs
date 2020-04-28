namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayCumulativeProbableCases
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

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayCumulativeProbableCases;

    internal sealed class DayCumulativeProbableCases_Calculation : IDayCumulativeProbableCases_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeProbableCases_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}