namespace C19M.M.C.Gumel2004.Classes.Variables.RecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.Gumel2004.Interfaces.Variables.RecoveredIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        // Constructor
        public R()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Gets dR/dt.
        /// </summary>
        /// <param name="I"></param>
        /// <param name="J"></param>
        /// <param name="R"></param>
        /// <param name="μ"></param>
        /// <param name="σ_1"></param>
        /// <param name="σ_2"></param>
        /// <returns></returns>
        public double getdRdt(
            double I,
            double J,
            double R,
            Iμ μ,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2)
        {
            return
                σ_1.Value * I
                +
                σ_2.Value * J
                -
                μ.Value * R;
        }
    }
}