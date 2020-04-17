namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths;

    internal interface IDayCumulativeDiseaseInducedDeaths
    {
        ImmutableList<IDayCumulativeDiseaseInducedDeaths_ResultElement> Value { get; }
    }
}