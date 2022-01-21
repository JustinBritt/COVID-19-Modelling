namespace C19M.M.C.A.Safi2010.Classes.Parameters.RecoveryRateHospitalizedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals;

    internal sealed class γ : Iγ
    {
        private ILog Log { get; }

        // Constructor
        public γ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the recovery rate for hospitalized individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}