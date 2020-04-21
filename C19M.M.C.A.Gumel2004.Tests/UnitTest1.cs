namespace C19M.M.C.A.Gumel2004.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    // Hl7
    using Hl7.Fhir.Model;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HongKong()
        {
            C19M.D.Gumel2004.Interfaces.IHongKong HK = new C19M.D.Gumel2004.Classes.HongKong();

            // Context
            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                HK.EndDate,
                HK.NumberDaysAfterStartDate,
                HK.StartDate,
                HK.DiseaseInducedDeathRateSymptomaticIndividuals,
                HK.DiseaseInducedDeathRateIsolatedIndividuals,
                HK.InitialValueAsymptomaticIndividuals,
                HK.InitialValueSymptomaticIndividuals,
                HK.InitialValueIsolatedIndividuals,
                HK.RecruitmentRateAsymptomaticIndividuals,
                HK.InitialValueQuarantinedIndividuals,
                HK.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                HK.InitialValueSusceptibleIndividuals,
                HK.BasicTransmissionCoefficient,
                HK.QuarantineRateAsymptomaticIndividuals,
                HK.IsolationRateSymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                HK.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                HK.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                HK.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                HK.NaturalDeathRate,
                HK.NetInflowRateSusceptibleIndividuals,
                HK.RecoveryRateSymptomaticIndividuals,
                HK.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                context);

            export.Solve();

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> E = export.DayAsymptomaticIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> I = export.DaySymptomaticIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> J = export.DayIsolatedIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Q = export.DayQuarantinedIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> R = export.DayRecoveredIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> S = export.DaySusceptibleIndividuals;

            var dayCumulativeProbableCases = export.DayCumulativeProbableCases;

            for (DateTime i = HK.StartDate.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date; i <= HK.EndDate.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date; i = i.AddDays(1))
            {
                System.Diagnostics.Debug.WriteLine(
                    dayCumulativeProbableCases.Where(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date == i).Select(w => w.Item2.Value.Value).SingleOrDefault());
            }
        }
    }
}