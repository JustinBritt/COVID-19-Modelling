namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayProbableCases;

    internal interface IDayProbableCases
    {
        ImmutableList<IDayProbableCases_ResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            FhirDateTime t_IndexElement);
    }
}