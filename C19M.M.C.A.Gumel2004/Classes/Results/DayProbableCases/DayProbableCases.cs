namespace C19M.M.C.A.Gumel2004.Classes.Results.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases;

    internal sealed class DayProbableCases : IDayProbableCases
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases(
            ImmutableList<IDayProbableCases_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IDayProbableCases_ResultElement> Value { get; }

        public double GetElementAt(
            DateTime t_IndexElement)
        {
            return this.Value
                .Where(x => x.t_IndexElement == t_IndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }
    }
}