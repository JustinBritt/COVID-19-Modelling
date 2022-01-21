namespace C19M.M.C.A.Safi2010.Classes.Parameters.HospitalizationRateInfectiousIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals;

    internal sealed class ϕ : Iϕ
    {
        private ILog Log { get; }

        // Constructor
        public ϕ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the hospitalization rate for infectious individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}