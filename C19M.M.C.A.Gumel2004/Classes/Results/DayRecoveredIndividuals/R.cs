namespace C19M.M.C.A.Gumel2004.Classes.Results.DayRecoveredIndividuals
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

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayRecoveredIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        // Constructor
        public R(
            ImmutableList<IR_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IR_ResultElement> Value { get; }

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