namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayProbableCases;

    using C19M.M.C.A.Gumel2006.Interfaces.Indices;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayProbableCases;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;
    
    internal sealed class DayProbableCases_Calculation : IDayProbableCases_Calculation
    {
        private ILog Log { get; }

        public DayProbableCases_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayProbableCases Calculate(
            It t,
            IE E,
            II I,
            IR R)
        {
            return new C19M.M.C.A.Gumel2006.Classes.Results.DayProbableCases.DayProbableCases(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2006.Classes.Calculations.DayProbableCases.DayProbableCases_ResultElement_Calculation().Calculate(
                        w,
                        E,
                        I,
                        R))
                .ToImmutableList());
        }
    }
}