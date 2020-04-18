namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IDayProbableCases_ResultElement
    {
        DateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the number of probable cases.
        /// </summary>
        double Value { get; }
    }
}