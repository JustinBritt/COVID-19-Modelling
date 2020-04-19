namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IΠ
    {
        /// <summary>
        /// Gets the net inflow rate of susceptible individuals per unit time.
        /// </summary>
        double Value { get; }
    }
}