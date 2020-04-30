namespace C19M.UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;

    using Hl7.Fhir.Model;

    public class Gumel2004
    {
        // Constructor
        public Gumel2004()
        {
            C19M.D.Gumel2004.Interfaces.IBeijing Beijing = new C19M.D.Gumel2004.Classes.Beijing();

            C19M.D.Gumel2004.Interfaces.IGreaterTorontoArea GreaterTorontoArea = new C19M.D.Gumel2004.Classes.GreaterTorontoArea();

            C19M.D.Gumel2004.Interfaces.IHongKong HongKong = new C19M.D.Gumel2004.Classes.HongKong();

            C19M.D.Gumel2004.Interfaces.ISingapore Singapore = new C19M.D.Gumel2004.Classes.Singapore();

            // Contexts
            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context Beijing_Context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                Beijing.EndDate,
                Beijing.NumberDaysAfterStartDate,
                Beijing.StartDate,
                Beijing.DiseaseInducedDeathRateSymptomaticIndividuals,
                Beijing.DiseaseInducedDeathRateIsolatedIndividuals,
                Beijing.InitialValueAsymptomaticIndividuals,
                Beijing.InitialValueSymptomaticIndividuals,
                Beijing.InitialValueIsolatedIndividuals,
                Beijing.RecruitmentRateAsymptomaticIndividuals,
                Beijing.InitialValueQuarantinedIndividuals,
                Beijing.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                Beijing.InitialValueSusceptibleIndividuals,
                Beijing.BasicTransmissionCoefficient,
                Beijing.QuarantineRateAsymptomaticIndividuals,
                Beijing.IsolationRateSymptomaticIndividuals,
                Beijing.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                Beijing.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                Beijing.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                Beijing.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                Beijing.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                Beijing.NaturalDeathRate,
                Beijing.NetInflowRateSusceptibleIndividuals,
                Beijing.RecoveryRateSymptomaticIndividuals,
                Beijing.RecoveryRateIsolatedIndividuals);

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

            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context HongKong_Context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                HongKong.EndDate,
                HongKong.NumberDaysAfterStartDate,
                HongKong.StartDate,
                HongKong.DiseaseInducedDeathRateSymptomaticIndividuals,
                HongKong.DiseaseInducedDeathRateIsolatedIndividuals,
                HongKong.InitialValueAsymptomaticIndividuals,
                HongKong.InitialValueSymptomaticIndividuals,
                HongKong.InitialValueIsolatedIndividuals,
                HongKong.RecruitmentRateAsymptomaticIndividuals,
                HongKong.InitialValueQuarantinedIndividuals,
                HongKong.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                HongKong.InitialValueSusceptibleIndividuals,
                HongKong.BasicTransmissionCoefficient,
                HongKong.QuarantineRateAsymptomaticIndividuals,
                HongKong.IsolationRateSymptomaticIndividuals,
                HongKong.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                HongKong.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                HongKong.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                HongKong.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                HongKong.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                HongKong.NaturalDeathRate,
                HongKong.NetInflowRateSusceptibleIndividuals,
                HongKong.RecoveryRateSymptomaticIndividuals,
                HongKong.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context Singapore_Context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                Singapore.EndDate,
                Singapore.NumberDaysAfterStartDate,
                Singapore.StartDate,
                Singapore.DiseaseInducedDeathRateSymptomaticIndividuals,
                Singapore.DiseaseInducedDeathRateIsolatedIndividuals,
                Singapore.InitialValueAsymptomaticIndividuals,
                Singapore.InitialValueSymptomaticIndividuals,
                Singapore.InitialValueIsolatedIndividuals,
                Singapore.RecruitmentRateAsymptomaticIndividuals,
                Singapore.InitialValueQuarantinedIndividuals,
                Singapore.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                Singapore.InitialValueSusceptibleIndividuals,
                Singapore.BasicTransmissionCoefficient,
                Singapore.QuarantineRateAsymptomaticIndividuals,
                Singapore.IsolationRateSymptomaticIndividuals,
                Singapore.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                Singapore.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                Singapore.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                Singapore.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                Singapore.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                Singapore.NaturalDeathRate,
                Singapore.NetInflowRateSusceptibleIndividuals,
                Singapore.RecoveryRateSymptomaticIndividuals,
                Singapore.RecoveryRateIsolatedIndividuals);

            // Exports
            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export Beijing_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                Beijing_Context);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export GreaterTorontoArea_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                GreaterTorontoArea_Context);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export HongKong_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                HongKong_Context);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export Singapore_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                Singapore_Context);

            Beijing_Export.Solve();

            GreaterTorontoArea_Export.Solve();

            HongKong_Export.Solve();

            Singapore_Export.Solve();

            this.Beijing_DayAsymptomaticIndividuals = Beijing_Export.DayAsymptomaticIndividuals;

            this.Beijing_DaySymptomaticIndividuals = Beijing_Export.DaySymptomaticIndividuals;

            this.Beijing_DayIsolatedIndividuals = Beijing_Export.DayIsolatedIndividuals;

            this.Beijing_DayQuarantinedIndividuals = Beijing_Export.DayQuarantinedIndividuals;

            this.Beijing_DayRecoveredIndividuals = Beijing_Export.DayRecoveredIndividuals;

            this.Beijing_DaySusceptibleIndividuals = Beijing_Export.DaySusceptibleIndividuals;

            this.Beijing_DayCumulativeDiseaseInducedDeaths = Beijing_Export.DayCumulativeDiseaseInducedDeaths;

            this.GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths = GreaterTorontoArea_Export.DayCumulativeDiseaseInducedDeaths;

            this.HongKong_DayCumulativeDiseaseInducedDeaths = HongKong_Export.DayCumulativeDiseaseInducedDeaths;

            this.Singapore_DayCumulativeDiseaseInducedDeaths = Singapore_Export.DayCumulativeDiseaseInducedDeaths;
        }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DaySusceptibleIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DaySusceptibleIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DayCumulativeDiseaseInducedDeaths { get; set; }

        // TODO: Update
        public string[] Days => this.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy")).ToArray();

        public decimal[] Beijing_DayAsymptomaticIndividuals_Array => this.Beijing_DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DaySymptomaticIndividuals_Array => this.Beijing_DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayIsolatedIndividuals_Array => this.Beijing_DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayQuarantinedIndividuals_Array => this.Beijing_DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayRecoveredndividuals_Array => this.Beijing_DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DaySusceptibleIndividuals_Array => this.Beijing_DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayCumulativeDiseaseInducedDeaths_Array => this.Beijing_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayAsymptomaticIndividuals_Array => this.GreaterTorontoArea_DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DaySymptomaticIndividuals_Array => this.GreaterTorontoArea_DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayIsolatedIndividuals_Array => this.GreaterTorontoArea_DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayQuarantinedIndividuals_Array => this.GreaterTorontoArea_DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayRecoveredndividuals_Array => this.GreaterTorontoArea_DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DaySusceptibleIndividuals_Array => this.GreaterTorontoArea_DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths_Array => this.GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayCumulativeDiseaseInducedDeaths_Array => this.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayCumulativeDiseaseInducedDeaths_Array => this.Singapore_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();
    }
}