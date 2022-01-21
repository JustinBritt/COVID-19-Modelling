namespace C19M.M.C.A.Gumel2004.Classes.Parameters.DiseaseInducedDeathRateIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals;

    internal sealed class d : C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals.Id
    {
        private ILog Log { get; }

        // Constructor
        public d(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}