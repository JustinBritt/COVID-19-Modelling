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
            C19M.D.Gumel2004.Interfaces.IGreaterTorontoArea GreaterTorontoArea = new C19M.D.Gumel2004.Classes.GreaterTorontoArea();

            C19M.D.Gumel2004.Interfaces.IHongKong HongKong = new C19M.D.Gumel2004.Classes.HongKong();

            // Context
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

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export GreaterTorontoArea_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                GreaterTorontoArea_Context);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export HongKong_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                HongKong_Context);

            GreaterTorontoArea_Export.Solve();

            HongKong_Export.Solve();

            this.GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths = GreaterTorontoArea_Export.DayCumulativeDiseaseInducedDeaths;

            this.HongKong_DayCumulativeDiseaseInducedDeaths = HongKong_Export.DayCumulativeDiseaseInducedDeaths;
        }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DayCumulativeDiseaseInducedDeaths { get; set; }

        // TODO: Update
        public string[] Days => this.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy")).ToArray();

        public decimal[] GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths_Array => this.GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayCumulativeDiseaseInducedDeaths_Array => this.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();
    }
}