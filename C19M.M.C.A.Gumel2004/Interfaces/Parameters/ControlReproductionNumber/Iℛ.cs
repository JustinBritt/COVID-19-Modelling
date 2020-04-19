namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.ControlReproductionNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iℛ
    {
        /// <summary>
        /// Gets the control reproduction number.
        /// </summary>
        double Value { get; }
    }
}