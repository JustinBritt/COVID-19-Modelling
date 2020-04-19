namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iε
    {
        /// <summary>
        /// Gets the transmission coefficient modification factor for isolated individuals.
        /// </summary>
        Func<DateTime, double> Value { get; }
    }
}