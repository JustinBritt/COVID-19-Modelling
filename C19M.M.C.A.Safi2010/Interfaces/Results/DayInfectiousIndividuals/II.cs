namespace C19M.M.C.A.Safi2010.Interfaces.Results.DayInfectiousIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayInfectiousIndividuals;

    internal interface II
    {
        ImmutableList<II_ResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
           FhirDateTime t_IndexElement);
    }
}