namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iμ
    {
        /// <summary>
        /// Gets the natural death rate. μ > 0.
        /// </summary>
        double Value { get; }
    }
}