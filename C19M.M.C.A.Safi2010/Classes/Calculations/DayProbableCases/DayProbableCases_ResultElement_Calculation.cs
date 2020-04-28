namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayProbableCases;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayProbableCases;

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