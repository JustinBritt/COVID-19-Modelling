namespace C19M.M.C.A.Gumel2004.Classes.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals;

    internal sealed class d : C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id
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
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}