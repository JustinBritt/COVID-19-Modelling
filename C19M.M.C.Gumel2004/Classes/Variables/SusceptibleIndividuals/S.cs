namespace C19M.M.C.Gumel2004.Classes.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals;

    using C19M.M.C.Gumel2004.Interfaces.Variables.SusceptibleIndividuals;

    internal sealed class S : IS
    {
        private ILog Log { get; }

        // Constructor
        public S(
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }

        /// <summary>
        /// Gets dS/dt.
        /// </summary>
        /// <param name="t_IndexElement"></param>
        /// <param name="E"></param>
        /// <param name="I"></param>
        /// <param name="J"></param>
        /// <param name="N"></param>
        /// <param name="Q"></param>
        /// <param name="S"></param>
        /// <param name="β"></param>
        /// <param name="ε_E"></param>
        /// <param name="ε_J"></param>
        /// <param name="ε_Q"></param>
        /// <param name="μ"></param>
        /// <param name="Π"></param>
        /// <returns></returns>
        public double GetdSdt(
            DateTime t_IndexElement,
            double E,
            double I,
            double J,
            double N,
            double Q,
            double S,
            Iβ β,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q,
            Iμ μ,
            IΠ Π)
        {
            return
                Π.Value
                -
                (S / N) * (β.Value) * (I + ε_E.Value * E + ε_Q.Value * Q + ε_J.Value.Invoke(t_IndexElement) * J)
                -
                μ.Value * S;
        }
    }
}