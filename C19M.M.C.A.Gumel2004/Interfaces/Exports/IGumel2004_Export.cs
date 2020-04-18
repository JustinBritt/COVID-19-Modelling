﻿namespace C19M.M.C.A.Gumel2004.Interfaces.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGumel2004_Export
    {
        ImmutableList<Tuple<DateTime, double>> DayCumulativeDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<DateTime, double>> DayDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<DateTime, double>> E { get; }

        ImmutableList<Tuple<DateTime, double>> I { get; }

        ImmutableList<Tuple<DateTime, double>> J { get; }

        ImmutableList<Tuple<DateTime, double>> Q { get; }

        ImmutableList<Tuple<DateTime, double>> R { get; }

        ImmutableList<Tuple<DateTime, double>> S { get; }

        void Solve();
    }
}