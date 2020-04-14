namespace C19M.M.C.A.Gumel2006.Classes.Parameters.EquilibriumPopulationWithoutDisease
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EquilibriumPopulationWithoutDisease;

    internal sealed class N : IN
    {
        private ILog Log { get; }

        // Constructor
        public N(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the equilibrium population (without disease).
        /// </summary>
        public double Value { get; }
    }
}