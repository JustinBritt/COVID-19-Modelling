namespace C19M.M.C.A.Safi2010.Classes.Parameters.QuarantineRateExposedIndividuals
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

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals;

    internal sealed class σ : Iσ
    {
        private ILog Log { get; }

        // Constructor
        public σ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the quarantine rate for exposed individuals;
        /// </summary>
        public FhirDecimal Value { get; }
    }
}