namespace C19M.M.C.A.Safi2010.Classes.Parameters.RecruitmentRateSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals;

    internal sealed class Π : IΠ
    {
        private ILog Log { get; }

        // Constructor
        public Π(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the recruitment rate of susceptible individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}