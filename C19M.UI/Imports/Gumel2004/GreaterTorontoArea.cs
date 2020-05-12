namespace C19M.UI.Imports.Gumel2004
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;

    public sealed class GreaterTorontoArea
    {
        // Constructor
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

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export GreaterTorontoArea_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                GreaterTorontoArea_Context);

            GreaterTorontoArea_Export.Solve();

            this.GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths = GreaterTorontoArea_Export.DayCumulativeDiseaseInducedDeaths;

            this.GreaterTorontoArea_DayAsymptomaticIndividuals = GreaterTorontoArea_Export.DayAsymptomaticIndividuals;

            this.GreaterTorontoArea_DaySymptomaticIndividuals = GreaterTorontoArea_Export.DaySymptomaticIndividuals;

            this.GreaterTorontoArea_DayIsolatedIndividuals = GreaterTorontoArea_Export.DayIsolatedIndividuals;

            this.GreaterTorontoArea_DayQuarantinedIndividuals = GreaterTorontoArea_Export.DayQuarantinedIndividuals;

            this.GreaterTorontoArea_DayRecoveredIndividuals = GreaterTorontoArea_Export.DayRecoveredIndividuals;

            this.GreaterTorontoArea_DaySusceptibleIndividuals = GreaterTorontoArea_Export.DaySusceptibleIndividuals;
        }

        private C19M.D.Gumel2004.Interfaces.IGreaterTorontoArea Data => new C19M.D.Gumel2004.Classes.GreaterTorontoArea();

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DaySusceptibleIndividuals { get; set; }
    }
}