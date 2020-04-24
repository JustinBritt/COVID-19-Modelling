namespace C19M.M.C.A.Safi2010.Classes.Parameters.HospitalizationRateQuarantinedIndividuals
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

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals;

    internal sealed class α : Iα
    {
        private ILog Log { get; }

        // Constructor
        public α(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the hospitalization rate for quarantined individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}