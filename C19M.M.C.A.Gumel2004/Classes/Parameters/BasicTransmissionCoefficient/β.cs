namespace C19M.M.C.A.Gumel2004.Classes.Parameters.BasicTransmissionCoefficient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;

    internal sealed class β : Iβ
    {
        private ILog Log { get; }

        // Constructor
        public β(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the basic transmission coefficient.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}