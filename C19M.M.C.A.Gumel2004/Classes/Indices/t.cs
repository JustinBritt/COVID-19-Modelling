namespace C19M.M.C.A.Gumel2004.Classes.Indices
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    internal sealed class t : It
    {
        private ILog Log { get; }

        // Constructor
        public t(
            DateTime endDate,
            Func<DateTime, int> numberDaysAfterStartDate,
            DateTime startDate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.EndDate = endDate;

            this.NumberDaysAfterStartDate = numberDaysAfterStartDate;

            this.StartDate = startDate;

            ImmutableList<DateTime>.Builder builder = ImmutableList.CreateBuilder<DateTime>();

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                builder.Add(
                    i);
            }

            this.Value = builder.ToImmutableList();
        }

        public DateTime EndDate { get; }

        public Func<DateTime, int> NumberDaysAfterStartDate { get; }

        public DateTime StartDate { get; }

        public ImmutableList<DateTime> Value { get; }
    }
}