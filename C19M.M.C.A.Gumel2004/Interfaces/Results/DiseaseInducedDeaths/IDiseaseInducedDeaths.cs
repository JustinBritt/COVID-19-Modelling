namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DiseaseInducedDeaths;

    internal interface IDiseaseInducedDeaths
    {
        ImmutableList<IDiseaseInducedDeaths_ResultElement> Value { get; }
    }
}