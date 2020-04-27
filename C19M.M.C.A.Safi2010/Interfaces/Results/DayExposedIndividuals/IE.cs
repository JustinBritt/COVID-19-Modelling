namespace C19M.M.C.A.Safi2010.Interfaces.Results.DayExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayExposedIndividuals;

    internal interface IE
    {
        ImmutableList<IE_ResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            FhirDateTime t_IndexElement);
    }
}