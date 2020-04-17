namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IJ_ResultElement
    {
        DateTime t_IndexElement { get; }

        double Value { get; }
    }
}