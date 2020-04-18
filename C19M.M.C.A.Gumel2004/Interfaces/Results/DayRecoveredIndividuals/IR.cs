namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayRecoveredIndividuals;

    internal interface IR
    {
        ImmutableList<IR_ResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            DateTime t_IndexElement);
    }
}