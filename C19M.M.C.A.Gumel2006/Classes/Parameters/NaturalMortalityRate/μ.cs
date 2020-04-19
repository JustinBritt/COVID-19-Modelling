namespace C19M.M.C.A.Gumel2006.Classes.Parameters.NaturalMortalityRate
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

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;

    internal sealed class μ : Iμ
    {
        private ILog Log { get; }

        // Constructor
        public μ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the natural mortality rate.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}