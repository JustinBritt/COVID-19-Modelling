namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;

    internal interface IR
    {
        double InitialValue { get; }

        double GetdRdt(
            Iδ δ,
            Iμ μ,
            double I,
            double R);
    }
}