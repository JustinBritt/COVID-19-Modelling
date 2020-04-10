namespace C19M.M.C.Gumel2004.Classes.Parameters.NaturalDeathRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal sealed class μ : Iμ
    {
        private ILog Log { get; }

        // Constructor
        public μ(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the natural death rate. μ > 0.
        /// </summary>
        public double Value { get; }
    }
}