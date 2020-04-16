namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.TotalPopulationSize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;

    internal interface IN
    {
        double InitialValue { get; }

        double GetdNdt(
            Id d,
            Iμ μ,
            IΠ Π,
            double I,
            double N);
    }
}