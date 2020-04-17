namespace C19M.M.C.A.Gumel2004.Classes.Results.DaySusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySusceptibleIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals;

    internal sealed class S : IS
    {
        private ILog Log { get; }

        // Constructor
        public S(
            ImmutableList<IS_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IS_ResultElement> Value { get; }
    }
}