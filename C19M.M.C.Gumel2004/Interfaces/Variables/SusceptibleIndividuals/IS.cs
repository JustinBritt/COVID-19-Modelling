namespace C19M.M.C.Gumel2004.Interfaces.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals;

    internal interface IS
    {
        double InitialValue { get; }

        /// <summary>
        /// Gets dS/dt.
        /// </summary>
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
        double GetdSdt(
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
            IΠ Π);
    }
}