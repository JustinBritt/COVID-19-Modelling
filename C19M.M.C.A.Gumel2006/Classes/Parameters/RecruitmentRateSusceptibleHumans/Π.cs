namespace C19M.M.C.A.Gumel2006.Classes.Parameters.RecruitmentRateSusceptibleHumans
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;

    internal sealed class Π : IΠ
    {
        private ILog Log { get; }

        // Constructor
        public Π(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the recruitment rate of susceptible humans.
        /// </summary>
        public double Value { get; }
    }
}