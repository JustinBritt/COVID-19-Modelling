namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iγ
    {
        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// </summary>
        Func<DateTime, double> Value { get; }
    }
}