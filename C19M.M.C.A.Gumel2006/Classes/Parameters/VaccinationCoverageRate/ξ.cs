namespace C19M.M.C.A.Gumel2006.Classes.Parameters.VaccinationCoverageRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;

    internal sealed class ξ : Iξ
    {
        private ILog Log { get; }

        // Constructor
        public ξ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the vaccination coverage rate.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}