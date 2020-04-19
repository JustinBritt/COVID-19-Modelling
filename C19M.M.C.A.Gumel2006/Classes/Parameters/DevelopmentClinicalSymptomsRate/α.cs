namespace C19M.M.C.A.Gumel2006.Classes.Parameters.DevelopmentClinicalSymptomsRate
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

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate;

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
        /// Gets the rate of development of clinical symptoms.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}