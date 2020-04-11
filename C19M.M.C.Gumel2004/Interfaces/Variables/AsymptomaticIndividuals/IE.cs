namespace C19M.M.C.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.RecruitmentRateAsymptomaticIndividuals;

    internal interface IE
    {
        /// <summary>
        /// Gets dE/dt.
        /// </summary>
        /// <param name="E"></param>
        /// <param name="I"></param>
        /// <param name="J"></param>
        /// <param name="N"></param>
        /// <param name="p"></param>
        /// <param name="Q"></param>
        /// <param name="S"></param>
        /// <param name="β"></param>
        /// <param name="γ_1"></param>
        /// <param name="γ_2"></param>
        /// <param name="ε_E"></param>
        /// <param name="ε_J"></param>
        /// <param name="ε_Q"></param>
        /// <param name="κ_1"></param>
        /// <param name="μ"></param>
        /// <returns></returns>
        double GetdEdt(
            double E,
            double I,
            double J,
            double N,
            Ip p,
            double Q,
            double S,
            Iβ β,
            C19M.M.C.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            Iμ μ);
    }
}