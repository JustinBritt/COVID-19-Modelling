namespace C19M.M.C.Gumel2004.Classes.Parameters.InitialValueSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.InitialValueSusceptibleIndividuals;

    internal sealed class S : IS
    {
        private ILog Log { get; }

        // Constructor
        public S(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the initial value for susceptible individuals.
        /// </summary>
        public double Value { get; }
    }
}