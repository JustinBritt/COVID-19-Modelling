namespace C19M.M.C.Gumel2004.Classes.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals;

    internal sealed class ε : Iε
    {
        private ILog Log { get; }

        // Constructor
        public ε(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the transmission coefficient modification factor for quarantined individuals.
        /// </summary>
        public double Value { get; }
    }
}