namespace C19M.M.C.A.Gumel2006.Classes.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Exports;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeProbableCases;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayProbableCases;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    public sealed class DiseaseTransmission_Export : IDiseaseTransmission_Export
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseTransmission_Export(
            IGumel2006_Context Gumel2006_Context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Gumel2006_Context = Gumel2006_Context;

            this.DiseaseTransmission_Solution = new C19M.M.C.A.Gumel2006.Classes.Solutions.DiseaseTransmission_Solution();
        }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeDiseaseInducedDeaths { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeProbableCases { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayDiseaseInducedDeaths { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayProbableCases { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayLatentIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayInfectedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayTreatedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayVaccinatedIndividuals { get; private set; }

        private IGumel2006_Context Gumel2006_Context { get; }

        private IDiseaseTransmission_Solution DiseaseTransmission_Solution { get; }

        public void Solve()
        {
            if (this.Gumel2006_Context != null && this.DiseaseTransmission_Solution != null)
            {
                this.DiseaseTransmission_Solution.Solve(
                    this.Gumel2006_Context);

                // DayCumulativeDiseaseInducedDeaths
                if (this.DiseaseTransmission_Solution.DayCumulativeDiseaseInducedDeaths != null)
                {
                    this.DayCumulativeDiseaseInducedDeaths = this.Convert_DayCumulativeDiseaseInducedDeaths(
                        this.DiseaseTransmission_Solution.DayCumulativeDiseaseInducedDeaths);
                }

                // DayLatentIndividuals
                if (this.DiseaseTransmission_Solution.E != null)
                {
                    this.DayLatentIndividuals = this.Convert_E(
                        this.DiseaseTransmission_Solution.E);
                }

                // DayInfectedIndividuals
                if (this.DiseaseTransmission_Solution.I != null)
                {
                    this.DayInfectedIndividuals = this.Convert_I(
                        this.DiseaseTransmission_Solution.I);
                }

                // DayTreatedIndividuals
                if (this.DiseaseTransmission_Solution.R != null)
                {
                    this.DayTreatedIndividuals = this.Convert_R(
                        this.DiseaseTransmission_Solution.R);
                }

                // DaySusceptibleIndividuals
                if (this.DiseaseTransmission_Solution.S != null)
                {
                    this.DaySusceptibleIndividuals = this.Convert_S(
                        this.DiseaseTransmission_Solution.S);
                }

                // DayVaccinatedIndividuals
                if (this.DiseaseTransmission_Solution.V != null)
                {
                    this.DayVaccinatedIndividuals = this.Convert_V(
                        this.DiseaseTransmission_Solution.V);
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