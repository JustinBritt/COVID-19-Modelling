namespace C19M.M.C.A.Safi2010.Classes.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals;

    internal sealed class ψ : Iψ
    {
        private ILog Log { get; }

        public ψ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the rate at which recovered individuals lose their infection-acquired immunity.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}