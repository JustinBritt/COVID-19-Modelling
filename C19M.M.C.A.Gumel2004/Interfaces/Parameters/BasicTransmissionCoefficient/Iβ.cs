﻿namespace C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iβ
    {
        /// <summary>
        /// Gets the basic transmission coefficient.
        /// </summary>
        double Value { get; }
    }
}