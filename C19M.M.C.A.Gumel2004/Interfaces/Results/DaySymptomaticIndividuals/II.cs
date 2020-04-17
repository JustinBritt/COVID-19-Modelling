namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySymptomaticIndividuals;

    internal interface II
    {
        ImmutableList<II_ResultElement> Value { get; }
    }
}