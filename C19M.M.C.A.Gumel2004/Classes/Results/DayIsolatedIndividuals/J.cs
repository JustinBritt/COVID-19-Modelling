namespace C19M.M.C.A.Gumel2004.Classes.Results.DayIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayIsolatedIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;

    internal sealed class J : IJ
    {
        private ILog Log { get; }

        // Constructor
        public J(
            ImmutableList<IJ_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IJ_ResultElement> Value { get; }
    }
}