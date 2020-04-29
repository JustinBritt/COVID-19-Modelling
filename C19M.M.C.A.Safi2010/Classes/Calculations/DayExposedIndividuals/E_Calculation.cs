namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayExposedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayExposedIndividuals;

    internal sealed class E_Calculation : IE_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public E_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}