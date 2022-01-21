namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayRecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayRecoveredIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals;

    internal sealed class R_Calculation : IR_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public R_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IR Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2004.Classes.Results.DayRecoveredIndividuals.R(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2004.Classes.Calculations.DayRecoveredIndividuals.R_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}