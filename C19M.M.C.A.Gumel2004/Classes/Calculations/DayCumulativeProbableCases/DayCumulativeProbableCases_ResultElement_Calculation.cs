namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases;

    internal sealed class DayCumulativeProbableCases_ResultElement_Calculation : IDayCumulativeProbableCases_ResultElement_Calculation
    {
        private ILog Log { get; }

        public DayCumulativeProbableCases_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayCumulativeProbableCases_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            IDayProbableCases dayProbableCases)
        {
            return new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayCumulativeProbableCases.DayCumulativeProbableCases_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    t.Value
                    .Where(w => w.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date >= t.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date && w.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date <= t_IndexElement.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                    .Select(w => dayProbableCases.GetElementAtAsdecimal(w))
                    .Max()));
        }
    }
}