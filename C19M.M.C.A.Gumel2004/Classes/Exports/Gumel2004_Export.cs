namespace C19M.M.C.A.Gumel2004.Classes.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2004.Interfaces.Exports;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeProbableCases;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Solutions;

    public sealed class Gumel2004_Export : IGumel2004_Export
    {
        private ILog Log { get; }

        public Gumel2004_Export(
            IGumel2004_Context Gumel2004_Context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Gumel2004_Context = Gumel2004_Context;

            this.Gumel2004_Solution = new C19M.M.C.A.Gumel2004.Classes.Solutions.Gumel2004_Solution();
        }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeDiseaseInducedDeaths { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeProbableCases { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayDiseaseInducedDeaths { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayProbableCases { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayAsymptomaticIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySymptomaticIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayIsolatedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayQuarantinedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayRecoveredIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; private set; }

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

                // DayCumulativeProbableCases
                if (this.Gumel2004_Solution.DayCumulativeProbableCases != null)
                {
                    this.DayCumulativeProbableCases = this.Convert_DayCumulativeProbableCases(
                        this.Gumel2004_Solution.DayCumulativeProbableCases);
                }

                // DayDiseaseInducedDeaths
                if (this.Gumel2004_Solution.DayDiseaseInducedDeaths != null)
                {
                    this.DayDiseaseInducedDeaths = this.Convert_DayDiseaseInducedDeaths(
                        this.Gumel2004_Solution.DayDiseaseInducedDeaths);
                }

                // DayProbableCases
                if (this.Gumel2004_Solution.DayProbableCases != null)
                {
                    this.DayProbableCases = this.Convert_DayProbableCases(
                        this.Gumel2004_Solution.DayProbableCases);
                }

                // DayAsymptomaticIndividuals
                if (this.Gumel2004_Solution.E != null)
                {
                    this.DayAsymptomaticIndividuals = this.Convert_E(
                        this.Gumel2004_Solution.E);
                }

                // DaySymptomaticIndividuals
                if (this.Gumel2004_Solution.I != null)
                {
                    this.DaySymptomaticIndividuals = this.Convert_I(
                        this.Gumel2004_Solution.I);
                }

                // DayIsolatedIndividuals
                if (this.Gumel2004_Solution.J != null)
                {
                    this.DayIsolatedIndividuals = this.Convert_J(
                        this.Gumel2004_Solution.J);
                }

                // DayQuarantinedIndividuals
                if (this.Gumel2004_Solution.Q != null)
                {
                    this.DayQuarantinedIndividuals = this.Convert_Q(
                        this.Gumel2004_Solution.Q);
                }

                // DayRecoveredIndividuals
                if (this.Gumel2004_Solution.R != null)
                {
                    this.DayRecoveredIndividuals = this.Convert_R(
                        this.Gumel2004_Solution.R);
                }

                // DaySusceptibleIndividuals
                if (this.Gumel2004_Solution.S != null)
                {
                    this.DaySusceptibleIndividuals = this.Convert_S(
                        this.Gumel2004_Solution.S);
                }
            }
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_DayCumulativeDiseaseInducedDeaths(
            IDayCumulativeDiseaseInducedDeaths value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_DayCumulativeProbableCases(
            IDayCumulativeProbableCases value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_DayDiseaseInducedDeaths(
            IDayDiseaseInducedDeaths value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_DayProbableCases(
            IDayProbableCases value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_E(
            IE value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_I(
            II value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_J(
            IJ value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_Q(
            IQ value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_R(
            IR value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_S(
            IS value)
        {
            return value.Value
                .Select(
                i => new Tuple<FhirDateTime, FhirDecimal>(
                    i.t_IndexElement,
                    i.Value))
                .ToImmutableList();
        }
    }
}