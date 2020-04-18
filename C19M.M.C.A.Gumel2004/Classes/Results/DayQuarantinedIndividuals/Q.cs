namespace C19M.M.C.A.Gumel2004.Classes.Results.DayQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayQuarantinedIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals;

    internal sealed class Q : IQ
    {
        private ILog Log { get; }

        // Constructor
        public Q(
            ImmutableList<IQ_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IQ_ResultElement> Value { get; }

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