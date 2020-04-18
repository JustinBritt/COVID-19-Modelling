namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayDiseaseInducedDeaths;

    internal interface IDayDiseaseInducedDeaths
    {
        ImmutableList<IDayDiseaseInducedDeaths_ResultElement> Value { get; }

        double GetElementAt(
            DateTime t_IndexElement);
    }
}