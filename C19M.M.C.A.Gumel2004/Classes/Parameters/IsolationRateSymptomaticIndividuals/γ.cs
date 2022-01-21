namespace C19M.M.C.A.Gumel2004.Classes.Parameters.IsolationRateSymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals;

    internal sealed class γ : Iγ
    {
        private ILog Log { get; }

        public γ(
            Func<FhirDateTime, FhirDecimal> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the isolation rate for symptomatic individuals.
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> Value { get; }
    }
}