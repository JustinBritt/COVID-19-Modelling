namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayProbableCases;

    internal sealed class DayProbableCases_Calculation : IDayProbableCases_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}