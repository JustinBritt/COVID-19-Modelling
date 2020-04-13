namespace C19M.M.C.Gumel2004.Interfaces.Variables.RecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal interface IR
    {
        double InitialValue { get; }

        double GetdRdt(
            double I,
            double J,
            double R,
            Iμ μ,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2);
    }
}