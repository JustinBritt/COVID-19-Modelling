namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;

    internal interface II
    {
        double InitialValue { get; }

        double GetdIdt(
            Id d,
            Iα α,
            Iδ δ,
            Iμ μ,
            double E,
            double I);
    }
}