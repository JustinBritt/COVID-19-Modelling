namespace C19M.M.C.A.Gumel2006.Classes.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Exports;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    internal sealed class EpidemicOutbreak_Export : IEpidemicOutbreak_Export
    {
        private ILog Log { get; }

        public EpidemicOutbreak_Export(
            IGumel2006_Context Gumel2006_Context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Gumel2006_Context = Gumel2006_Context;

            this.EpidemicOutbreak_Solution = new C19M.M.C.A.Gumel2006.Classes.Solutions.EpidemicOutbreak_Solution();
        }

        private IGumel2006_Context Gumel2006_Context { get; }

        private IEpidemicOutbreak_Solution EpidemicOutbreak_Solution { get; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayLatentIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayInfectedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayTreatedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayVaccinatedIndividuals { get; private set; }

        public void Solve()
        {
            if (this.Gumel2006_Context != null && this.EpidemicOutbreak_Solution != null)
            {
                this.EpidemicOutbreak_Solution.Solve(
                    this.Gumel2006_Context);

                // DayLatentIndividuals
                if (this.EpidemicOutbreak_Solution.E != null)
                {
                    this.DayLatentIndividuals = this.Convert_E(
                        this.EpidemicOutbreak_Solution.E);
                }

                // DayInfectedIndividuals
                if (this.EpidemicOutbreak_Solution.I != null)
                {
                    this.DayInfectedIndividuals = this.Convert_I(
                        this.EpidemicOutbreak_Solution.I);
                }

                // DayTreatedIndividuals
                if (this.EpidemicOutbreak_Solution.R != null)
                {
                    this.DayTreatedIndividuals = this.Convert_R(
                        this.EpidemicOutbreak_Solution.R);
                }

                // DaySusceptibleIndividuals
                if (this.EpidemicOutbreak_Solution.S != null)
                {
                    this.DaySusceptibleIndividuals = this.Convert_S(
                        this.EpidemicOutbreak_Solution.S);
                }

                // DayVaccinatedIndividuals
                if (this.EpidemicOutbreak_Solution.V != null)
                {
                    this.DayVaccinatedIndividuals = this.Convert_V(
                        this.EpidemicOutbreak_Solution.V);
                }
            }
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

        private ImmutableList<Tuple<FhirDateTime, FhirDecimal>> Convert_V(
            IV value)
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