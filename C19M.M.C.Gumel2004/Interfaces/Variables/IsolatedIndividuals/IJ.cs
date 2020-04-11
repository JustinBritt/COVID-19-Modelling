namespace C19M.M.C.Gumel2004.Interfaces.Variables.IsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal interface IJ
    {
        /// <summary>
        /// Gets dJ/dt.
        /// </summary>
        /// <param name="d_2"></param>
        /// <param name="I"></param>
        /// <param name="J"></param>
        /// <param name="Q"></param>
        /// <param name="γ_2"></param>
        /// <param name="κ_2"></param>
        /// <param name="μ"></param>
        /// <param name="σ_2"></param>
        /// <returns></returns>
        double GetdJdt(
            Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals.Id d_2,
            double I,
            double J,
            double Q,
            C19M.M.C.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2);
    }
}