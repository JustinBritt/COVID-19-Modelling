namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySusceptibleIndividuals;

    internal interface IS
    {
        ImmutableList<IS_ResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            DateTime t_IndexElement);
    }
}