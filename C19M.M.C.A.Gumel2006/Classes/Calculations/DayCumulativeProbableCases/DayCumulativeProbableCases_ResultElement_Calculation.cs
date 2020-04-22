namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayCumulativeProbableCases
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

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2006.Interfaces.Indices;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayProbableCases;

    internal sealed class DayCumulativeProbableCases_ResultElement_Calculation : IDayCumulativeProbableCases_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayCumulativeProbableCases_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayCumulativeProbableCases_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            IDayProbableCases dayProbableCases)
        {
            return new C19M.M.C.A.Gumel2006.Classes.ResultElements.DayCumulativeProbableCases.DayCumulativeProbableCases_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    t.Value
                    .Where(w => w.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date >= t.StartDate.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date && w.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date <= t_IndexElement.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date)
                    .Select(w => dayProbableCases.GetElementAtAsdecimal(w))
                    .Max()));
        }
    }
}