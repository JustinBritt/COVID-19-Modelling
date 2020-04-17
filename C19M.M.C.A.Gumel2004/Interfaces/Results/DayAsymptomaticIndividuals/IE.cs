namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DayAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayAsymptomaticIndividuals;

    internal interface IE
    {
        ImmutableList<IE_ResultElement> Value { get; }
    }
}