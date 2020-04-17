namespace C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayAsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IE_ResultElement
    {
        DateTime t_IndexElement { get; }

        double Value { get; }
    }
}