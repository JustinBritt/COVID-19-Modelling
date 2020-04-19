namespace C19M.M.C.A.Gumel2004.Interfaces.Indices
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface It
    {
        DateTime EndDate { get; }

        Func<DateTime, PositiveInt> NumberDaysAfterStartDate { get; }

        DateTime StartDate { get; }

        ImmutableList<DateTime> Value { get; }
    }
}