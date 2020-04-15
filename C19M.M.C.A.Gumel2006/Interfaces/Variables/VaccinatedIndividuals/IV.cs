namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    internal interface IV
    {
        double InitialValue { get; }

        double GetdVdt(
            Iβ β,
            Iμ μ,
            Iξ ξ,
            Iτ τ,
            double I,
            double S,
            double V);
    }
}