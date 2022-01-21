namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayIsolatedIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;

    internal sealed class J_Calculation : IJ_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public J_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IJ Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2004.Classes.Results.DayIsolatedIndividuals.J(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2004.Classes.Calculations.DayIsolatedIndividuals.J_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}