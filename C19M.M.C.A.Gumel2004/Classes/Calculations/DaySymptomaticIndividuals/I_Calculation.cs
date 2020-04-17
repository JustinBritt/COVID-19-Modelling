namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DaySymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DaySymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    internal sealed class I_Calculation : II_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public I_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public II Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2004.Classes.Results.DaySymptomaticIndividuals.I(
                t.Value.Select(
                    w => (C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySymptomaticIndividuals.II_ResultElement)new C19M.M.C.A.Gumel2004.Classes.ResultElements.DaySymptomaticIndividuals.I_ResultElement(
                        w,
                        RungeKuttaResults[t.NumberDaysAfterStartDate.Invoke(w)][1]))
                .ToImmutableList());
        }
    }
}