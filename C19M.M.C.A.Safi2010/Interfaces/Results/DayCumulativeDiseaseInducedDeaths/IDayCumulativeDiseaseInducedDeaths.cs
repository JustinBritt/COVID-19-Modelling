namespace C19M.M.C.A.Safi2010.Interfaces.Results.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths;

    internal interface IDayCumulativeDiseaseInducedDeaths
    {
        ImmutableList<IDayCumulativeDiseaseInducedDeaths_ResultElement> Value { get; }
    }
}