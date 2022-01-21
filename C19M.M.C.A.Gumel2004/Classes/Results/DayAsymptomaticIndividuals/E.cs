namespace C19M.M.C.A.Gumel2004.Classes.Results.DayAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayAsymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayAsymptomaticIndividuals;

    internal sealed class E : IE
    {
        private ILog Log { get; }

        // Constructor
        public E(
            ImmutableList<IE_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IE_ResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            FhirDateTime t_IndexElement)
        {
            return this.Value
                .Where(x => x.t_IndexElement.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date == t_IndexElement.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}