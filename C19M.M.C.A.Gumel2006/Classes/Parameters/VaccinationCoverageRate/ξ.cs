namespace C19M.M.C.A.Gumel2006.Classes.Parameters.VaccinationCoverageRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;

    internal sealed class ξ : Iξ
    {
        private ILog Log { get; }

        // Constructor
        public ξ(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the vaccination coverage rate.
        /// </summary>
        public double Value { get; }
    }
}