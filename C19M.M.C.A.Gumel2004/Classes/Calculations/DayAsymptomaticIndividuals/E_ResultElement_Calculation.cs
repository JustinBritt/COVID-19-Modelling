﻿namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayAsymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayAsymptomaticIndividuals;

    internal sealed class E_ResultElement_Calculation : IE_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public E_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IE_ResultElement Calculate(
            DateTime t_IndexElement,
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayAsymptomaticIndividuals.E_ResultElement(
                t_IndexElement,
                RungeKuttaResults[t.NumberDaysAfterStartDate.Invoke(t_IndexElement)][0]);
        }
    }
}