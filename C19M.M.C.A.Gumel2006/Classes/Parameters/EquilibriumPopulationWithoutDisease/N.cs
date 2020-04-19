namespace C19M.M.C.A.Gumel2006.Classes.Parameters.EquilibriumPopulationWithoutDisease
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

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EquilibriumPopulationWithoutDisease;

    internal sealed class N : IN
    {
        private ILog Log { get; }

        // Constructor
        public N(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the equilibrium population (without disease).
        /// </summary>
        public FhirDecimal Value { get; }
    }
}