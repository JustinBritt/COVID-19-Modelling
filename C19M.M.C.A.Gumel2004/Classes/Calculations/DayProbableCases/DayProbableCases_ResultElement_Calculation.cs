﻿namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    internal sealed class DayProbableCases_ResultElement_Calculation : IDayProbableCases_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}