namespace C19M.M.C.Gumel2004.Classes.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.Gumel2004.Interfaces.Variables.QuarantinedIndividuals;

    internal sealed class Q : IQ
    {
        private ILog Log { get; }

        // Constructor
        public Q()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Gets dQ/dt.
        /// </summary>
        /// <param name="E"></param>
        /// <param name="Q"></param>
        /// <param name="γ_1"></param>
        /// <param name="κ_2"></param>
        /// <param name="μ"></param>
        /// <returns></returns>
        public double GetdQdt(
            double E,
            double Q,
            C19M.M.C.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ)
        {
            return
                γ_1.Value * E
                -
                (κ_2.Value + μ.Value) * Q;
        }
    }
}