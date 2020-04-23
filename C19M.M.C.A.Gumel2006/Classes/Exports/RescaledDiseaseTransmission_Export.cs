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

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    public sealed class RescaledDiseaseTransmission_Export : IRescaledDiseaseTransmission_Export
    {
        private ILog Log { get; }

        // Constructor
        public RescaledDiseaseTransmission_Export(
            IGumel2006_Context Gumel2006_Context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Gumel2006_Context = Gumel2006_Context;

            this.RescaledDiseaseTransmission_Solution = new C19M.M.C.A.Gumel2006.Classes.Solutions.RescaledDiseaseTransmission_Solution();
        }

        private IGumel2006_Context Gumel2006_Context { get; }

        private IRescaledDiseaseTransmission_Solution RescaledDiseaseTransmission_Solution { get; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayLatentIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayInfectedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayTreatedIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; private set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayVaccinatedIndividuals { get; private set; }

        public void Solve()
        {
            if (this.Gumel2006_Context != null && this.RescaledDiseaseTransmission_Solution != null)
            {
                this.RescaledDiseaseTransmission_Solution.Solve(
                    this.Gumel2006_Context);

                // DayLatentIndividuals
                if (this.RescaledDiseaseTransmission_Solution.E != null)
                {
                    this.DayLatentIndividuals = this.Convert_E(
                        this.RescaledDiseaseTransmission_Solution.E);
                }

                // DayInfectedIndividuals
                if (this.RescaledDiseaseTransmission_Solution.I != null)
                {
                    this.DayInfectedIndividuals = this.Convert_I(
                        this.RescaledDiseaseTransmission_Solution.I);
                }

                // DayTreatedIndividuals
                if (this.RescaledDiseaseTransmission_Solution.R != null)
                {
                    this.DayTreatedIndividuals = this.Convert_R(
                        this.RescaledDiseaseTransmission_Solution.R);
                }

                // DaySusceptibleIndividuals
                if (this.RescaledDiseaseTransmission_Solution.S != null)
                {
                    this.DaySusceptibleIndividuals = this.Convert_S(
                        this.RescaledDiseaseTransmission_Solution.S);
                }

                // DayVaccinatedIndividuals
                if (this.RescaledDiseaseTransmission_Solution.V != null)
                {
                    this.DayVaccinatedIndividuals = this.Convert_V(
                        this.RescaledDiseaseTransmission_Solution.V);
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