namespace C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled;

    internal sealed class ε : Iε
    {
        private ILog Log { get; }

        // Constructor
        public ε(
            double diseaseInducedMortalityRate,
            double recoveryRate,
            double naturalMortalityRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value =
                naturalMortalityRate
                /
                (diseaseInducedMortalityRate + recoveryRate + naturalMortalityRate);
        }

        public double Value { get; }
    }
}