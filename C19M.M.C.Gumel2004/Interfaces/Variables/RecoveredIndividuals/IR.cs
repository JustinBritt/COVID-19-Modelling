namespace C19M.M.C.Gumel2004.Interfaces.Variables.RecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Oslo
    using Microsoft.Research.Oslo;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal interface IR
    {
        Vector Value { get; }

        // <summary>
        /// Gets dR/dt.
        /// </summary>
        /// <param name="I"></param>
        /// <param name="J"></param>
        /// <param name="R"></param>
        /// <param name="μ"></param>
        /// <param name="σ_1"></param>
        /// <param name="σ_2"></param>
        /// <returns></returns>
        double getdRdt(
            double I,
            double J,
            double R,
            Iμ μ,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2);
    }
}