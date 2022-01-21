namespace C19M.M.C.A.Safi2010.Classes.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals;

    internal sealed class κ : Iκ
    {
        private ILog Log { get; }

        public κ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the rate at which exposed individuals develop disease symptoms.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}