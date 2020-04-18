namespace C19M.M.C.A.Gumel2004.Interfaces.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGumel2004_Export
    {
        ImmutableList<Tuple<DateTime, double>> DayCumulativeDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<DateTime, double>> DayDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<DateTime, double>> DayAsymptomaticIndividuals { get; }

        ImmutableList<Tuple<DateTime, double>> DaySymptomaticIndividuals { get; }

        ImmutableList<Tuple<DateTime, double>> DayIsolatedIndividuals { get; }

        ImmutableList<Tuple<DateTime, double>> DayQuarantinedIndividuals { get; }

        ImmutableList<Tuple<DateTime, double>> R { get; }

        ImmutableList<Tuple<DateTime, double>> S { get; }

        void Solve();
    }
}