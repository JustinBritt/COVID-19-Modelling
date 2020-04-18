﻿namespace C19M.M.C.A.Gumel2004.Classes.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2004.Interfaces.Exports;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Solutions;

    public sealed class Gumel2004_Export : IGumel2004_Export
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Export(
            IGumel2004_Context Gumel2004_Context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Gumel2004_Context = Gumel2004_Context;

            this.Gumel2004_Solution = new C19M.M.C.A.Gumel2004.Classes.Solutions.Gumel2004_Solution();
        }

        public ImmutableList<Tuple<DateTime, double>> DayCumulativeDiseaseInducedDeaths { get; private set; }

        public ImmutableList<Tuple<DateTime, double>> DayDiseaseInducedDeaths { get; private set; }

        public ImmutableList<Tuple<DateTime, double>> E { get; private set; }

        public ImmutableList<Tuple<DateTime, double>> I { get; private set; }

        public ImmutableList<Tuple<DateTime, double>> J { get; private set; }

        public ImmutableList<Tuple<DateTime, double>> Q { get; private set; }

        public ImmutableList<Tuple<DateTime, double>> R { get; private set; }

        public ImmutableList<Tuple<DateTime, double>> S { get; private set; }

        private IGumel2004_Context Gumel2004_Context { get; }

        private IGumel2004_Solution Gumel2004_Solution { get; }

        public void Solve()
        {
            if (this.Gumel2004_Context != null && this.Gumel2004_Solution != null)
            {
                this.Gumel2004_Solution.Solve(
                    this.Gumel2004_Context);

                // DayCumulativeDiseaseInducedDeaths
                if (this.Gumel2004_Solution.DayCumulativeDiseaseInducedDeaths != null)
                {
                    this.DayCumulativeDiseaseInducedDeaths = this.Convert_DayCumulativeDiseaseInducedDeaths(
                        this.Gumel2004_Solution.DayCumulativeDiseaseInducedDeaths);
                }

                // DayDiseaseInducedDeaths
                if (this.Gumel2004_Solution.DayDiseaseInducedDeaths != null)
                {
                    this.DayDiseaseInducedDeaths = this.Convert_DayDiseaseInducedDeaths(
                        this.Gumel2004_Solution.DayDiseaseInducedDeaths);
                }

                // E
                if (this.Gumel2004_Solution.E != null)
                {
                    this.E = this.Convert_E(
                        this.Gumel2004_Solution.E);
                }

                // I
                if (this.Gumel2004_Solution.I != null)
                {
                    this.I = this.Convert_I(
                        this.Gumel2004_Solution.I);
                }

                // J
                if (this.Gumel2004_Solution.J != null)
                {
                    this.J = this.Convert_J(
                        this.Gumel2004_Solution.J);
                }

                // Q
                if (this.Gumel2004_Solution.Q != null)
                {
                    this.Q = this.Convert_Q(
                        this.Gumel2004_Solution.Q);
                }

                // R
                if (this.Gumel2004_Solution.R != null)
                {
                    this.R = this.Convert_R(
                        this.Gumel2004_Solution.R);
                }

                // S
                if (this.Gumel2004_Solution.S != null)
                {
                    this.S = this.Convert_S(
                        this.Gumel2004_Solution.S);
                }
            }
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_DayCumulativeDiseaseInducedDeaths(
            IDayCumulativeDiseaseInducedDeaths value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_DayDiseaseInducedDeaths(
            IDayDiseaseInducedDeaths value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_E(
            IE value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_I(
            II value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_J(
            IJ value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_Q(
            IQ value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_R(
            IR value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<DateTime, double>> Convert_S(
            IS value)
        {
            return value.Value
                .Select(
                i => new Tuple<DateTime, double>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }
    }
}