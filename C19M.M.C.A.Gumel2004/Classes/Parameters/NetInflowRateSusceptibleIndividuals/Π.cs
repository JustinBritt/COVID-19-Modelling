namespace C19M.M.C.A.Gumel2004.Classes.Parameters.NetInflowRateSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals;

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
        /// Gets the net inflow rate of susceptible individuals per unit time.
        /// </summary>
        public double Value { get; }
    }
}