namespace C19M.M.C.A.Gumel2006.Classes.Indices
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Indices;

    internal sealed class t : It
    {
        private ILog Log { get; }

        public t(
            FhirDateTime endDate,
            Func<FhirDateTime, PositiveInt> numberDaysAfterStartDate,
            FhirDateTime startDate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.EndDate = endDate;

            this.NumberDaysAfterStartDate = numberDaysAfterStartDate;

            this.StartDate = startDate;

            ImmutableList<FhirDateTime>.Builder builder = ImmutableList.CreateBuilder<FhirDateTime>();

            for (DateTime i = startDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date; i <= endDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date; i = i.AddDays(1))
            {
                builder.Add(
                    new FhirDateTime(
                        new DateTimeOffset(
                            i)));
            }

            this.Value = builder.ToImmutableList();
        }

        public FhirDateTime EndDate { get; }

        public Func<FhirDateTime, PositiveInt> NumberDaysAfterStartDate { get; }

        public FhirDateTime StartDate { get; }

        public ImmutableList<FhirDateTime> Value { get; }
    }
}