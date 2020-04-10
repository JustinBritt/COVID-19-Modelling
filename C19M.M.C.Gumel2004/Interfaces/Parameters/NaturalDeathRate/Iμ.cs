namespace C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface Iμ
    {
        /// <summary>
        /// Gets the positive Value (i.e., μ > 0) of the natural death rate.
        /// </summary>
        double Value { get; }
    }
}