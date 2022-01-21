namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    internal sealed class DayProbableCases_Calculation : IDayProbableCases_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayProbableCases Calculate(
            It t,
            II I,
            IJ J,
            IQ Q,
            IR R)
        {
            return new C19M.M.C.A.Gumel2004.Classes.Results.DayProbableCases.DayProbableCases(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2004.Classes.Calculations.DayProbableCases.DayProbableCases_ResultElement_Calculation().Calculate(
                        w,
                        I,
                        J,
                        Q,
                        R))
                .ToImmutableList());
        }
    }
}