namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases;

    internal sealed class DayCumulativeProbableCases_ResultElement_Calculation : IDayCumulativeProbableCases_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeProbableCases_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayCumulativeProbableCases_ResultElement Calculate(
            DateTime t_IndexElement,
            It t,
            IDayProbableCases dayProbableCases)
        {
            double val1 = dayProbableCases.GetElementAt(t_IndexElement);

            double minVal = dayProbableCases.Value.Where(w => w.t_IndexElement <= t_IndexElement).Select(w => w.Value).Max();

            double val2 = Math.Max(val1, minVal);

            return new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayCumulativeProbableCases.DayCumulativeProbableCases_ResultElement(
                t_IndexElement,
                val2);
        }
    }
}