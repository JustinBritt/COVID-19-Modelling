namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IS_ResultElement
    {
        DateTime t_IndexElement { get; }

        double Value { get; }
    }
}