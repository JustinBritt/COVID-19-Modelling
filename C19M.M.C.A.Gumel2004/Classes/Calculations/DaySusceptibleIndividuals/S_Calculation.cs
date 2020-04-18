namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DaySusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DaySusceptibleIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals;

    internal sealed class S_Calculation : IS_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public S_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IS Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2004.Classes.Results.DaySusceptibleIndividuals.S(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2004.Classes.Calculations.DaySusceptibleIndividuals.S_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}