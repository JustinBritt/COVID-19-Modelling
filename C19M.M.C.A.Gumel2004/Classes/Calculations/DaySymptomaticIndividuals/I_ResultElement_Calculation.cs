﻿namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DaySymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DaySymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySymptomaticIndividuals;

    internal sealed class I_ResultElement_Calculation : II_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public I_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public II_ResultElement Calculate()
        {
            throw new NotImplementedException();
        }
    }
}