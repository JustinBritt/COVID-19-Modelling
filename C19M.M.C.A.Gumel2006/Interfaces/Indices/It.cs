namespace C19M.M.C.A.Gumel2006.Interfaces.Indices
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
        FhirDateTime EndDate { get; }

        Func<FhirDateTime, PositiveInt> NumberDaysAfterStartDate { get; }

        FhirDateTime StartDate { get; }

        ImmutableList<FhirDateTime> Value { get; }
    }
}