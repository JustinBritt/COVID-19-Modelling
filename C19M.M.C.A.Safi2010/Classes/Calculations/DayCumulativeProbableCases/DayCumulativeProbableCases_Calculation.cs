namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayCumulativeProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayCumulativeProbableCases;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayCumulativeProbableCases;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayProbableCases;

    internal sealed class DayCumulativeProbableCases_Calculation : IDayCumulativeProbableCases_Calculation
    {
        private ILog Log { get; }

        public DayCumulativeProbableCases_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayCumulativeProbableCases Calculate(
            It t,
            IDayProbableCases dayProbableCases)
        {
            return new C19M.M.C.A.Safi2010.Classes.Results.DayCumulativeProbableCases.DayCumulativeProbableCases(
                t.Value.Select(
                    w => new C19M.M.C.A.Safi2010.Classes.Calculations.DayCumulativeProbableCases.DayCumulativeProbableCases_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        dayProbableCases))
                .ToImmutableList());
        }
    }
}