namespace C19M.M.C.A.Safi2010.Interfaces.Results.DayCumulativeProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayCumulativeProbableCases;

    internal interface IDayCumulativeProbableCases
    {
        ImmutableList<IDayCumulativeProbableCases_ResultElement> Value { get; }
    }
}