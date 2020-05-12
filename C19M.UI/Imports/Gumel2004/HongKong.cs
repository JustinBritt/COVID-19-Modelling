namespace C19M.UI.Imports.Gumel2004
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;

    // Hl7
    using Hl7.Fhir.Model;

    public sealed class HongKong
    {
        // Constructor
        public HongKong()
        {
            C19M.D.Gumel2004.Interfaces.IHongKong HongKong = new C19M.D.Gumel2004.Classes.HongKong();

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

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export HongKong_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                HongKong_Context);

            HongKong_Export.Solve();

            this.DayCumulativeDiseaseInducedDeaths = HongKong_Export.DayCumulativeDiseaseInducedDeaths;

            this.DayAsymptomaticIndividuals = HongKong_Export.DayAsymptomaticIndividuals;

            this.DaySymptomaticIndividuals = HongKong_Export.DaySymptomaticIndividuals;

            this.DayIsolatedIndividuals = HongKong_Export.DayIsolatedIndividuals;

            this.DayQuarantinedIndividuals = HongKong_Export.DayQuarantinedIndividuals;

            this.DayRecoveredIndividuals = HongKong_Export.DayRecoveredIndividuals;

            this.DaySusceptibleIndividuals = HongKong_Export.DaySusceptibleIndividuals;
        }

        private C19M.D.Gumel2004.Interfaces.IHongKong Data => new C19M.D.Gumel2004.Classes.HongKong();

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; set; }
    }
}