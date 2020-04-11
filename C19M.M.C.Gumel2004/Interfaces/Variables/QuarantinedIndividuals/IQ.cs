namespace C19M.M.C.Gumel2004.Interfaces.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal interface IQ
    {
        /// <summary>
        /// Gets dQ/dt.
        /// </summary>
        /// <param name="E"></param>
        /// <param name="Q"></param>
        /// <param name="γ_1"></param>
        /// <param name="κ_2"></param>
        /// <param name="μ"></param>
        /// <returns></returns>
        double GetdQdt(
            double E,
            double Q,
            C19M.M.C.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ);
    }
}