namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeProbableCases;

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