namespace C19M.M.C.A.Gumel2004.Interfaces.Indices
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface It
    {
        DateTime EndDate { get; }

        Func<DateTime, int> NumberDaysAfterStartDate { get; }

        DateTime StartDate { get; }

        ImmutableList<DateTime> Value { get; }
    }
}