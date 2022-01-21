namespace C19M.M.C.A.Gumel2004.Classes.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals;

    internal sealed class ε : Iε
    {
        private ILog Log { get; }

        public ε(
            Func<FhirDateTime, FhirDecimal> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// </summary>
        public Func<FhirDateTime, FhirDecimal> Value { get; }
    }
}