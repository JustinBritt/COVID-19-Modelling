namespace C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayProbableCases;

    internal interface IDayProbableCases
    {
        ImmutableList<IDayProbableCases_ResultElement> Value { get; }

        double GetElementAt(
            DateTime t_IndexElement);
    }
}