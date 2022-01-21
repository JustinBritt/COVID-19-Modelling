namespace C19M.UI.Imports.Gumel2004
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;

    using Hl7.Fhir.Model;

    public sealed class GreaterTorontoArea
    {
        public GreaterTorontoArea()
        {
            C19M.D.Gumel2004.Interfaces.IGreaterTorontoArea GreaterTorontoArea = new C19M.D.Gumel2004.Classes.GreaterTorontoArea();

            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context GreaterTorontoArea_Context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                GreaterTorontoArea.EndDate,
                GreaterTorontoArea.NumberDaysAfterStartDate,
                GreaterTorontoArea.StartDate,
                GreaterTorontoArea.DiseaseInducedDeathRateSymptomaticIndividuals,
                GreaterTorontoArea.DiseaseInducedDeathRateIsolatedIndividuals,
                GreaterTorontoArea.InitialValueAsymptomaticIndividuals,
                GreaterTorontoArea.InitialValueSymptomaticIndividuals,
                GreaterTorontoArea.InitialValueIsolatedIndividuals,
                GreaterTorontoArea.RecruitmentRateAsymptomaticIndividuals,
                GreaterTorontoArea.InitialValueQuarantinedIndividuals,
                GreaterTorontoArea.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                GreaterTorontoArea.InitialValueSusceptibleIndividuals,
                GreaterTorontoArea.BasicTransmissionCoefficient,
                GreaterTorontoArea.QuarantineRateAsymptomaticIndividuals,
                GreaterTorontoArea.IsolationRateSymptomaticIndividuals,
                GreaterTorontoArea.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                GreaterTorontoArea.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                GreaterTorontoArea.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                GreaterTorontoArea.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                GreaterTorontoArea.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                GreaterTorontoArea.NaturalDeathRate,
                GreaterTorontoArea.NetInflowRateSusceptibleIndividuals,
                GreaterTorontoArea.RecoveryRateSymptomaticIndividuals,
                GreaterTorontoArea.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                GreaterTorontoArea_Context);

            export.Solve();

            this.DayCumulativeDiseaseInducedDeaths = export.DayCumulativeDiseaseInducedDeaths;

            this.DayAsymptomaticIndividuals = export.DayAsymptomaticIndividuals;

            this.DaySymptomaticIndividuals = export.DaySymptomaticIndividuals;

            this.DayIsolatedIndividuals = export.DayIsolatedIndividuals;

            this.DayQuarantinedIndividuals = export.DayQuarantinedIndividuals;

            this.DayRecoveredIndividuals = export.DayRecoveredIndividuals;

            this.DaySusceptibleIndividuals = export.DaySusceptibleIndividuals;
        }

        private C19M.D.Gumel2004.Interfaces.IGreaterTorontoArea Data => new C19M.D.Gumel2004.Classes.GreaterTorontoArea();

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySymptomaticIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayIsolatedIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayQuarantinedIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayRecoveredIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; set; }
    }
}