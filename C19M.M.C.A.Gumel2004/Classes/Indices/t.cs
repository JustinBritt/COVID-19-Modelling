namespace C19M.M.C.A.Gumel2004.Classes.Indices
{
    using System;
    using System.Collections.Generic;
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
        }

        public DateTime EndDate { get; }

        public Func<DateTime, int> NumberDaysAfterStartDate { get; }

        public DateTime StartDate { get; }
    }
}