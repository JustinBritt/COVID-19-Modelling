namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    internal interface IE
    {
        double InitialValue { get; }

        double GetdEdt(
            Iα α,
            Iβ β,
            Iμ μ,
            Iτ τ,
            double E,
            double I,
            double S,
            double V);
    }
}