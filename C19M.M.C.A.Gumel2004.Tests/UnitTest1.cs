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
        public void TestMethod1()
        {
            C19M.D.Gumel2004.Interfaces.IHongKong HK = new C19M.D.Gumel2004.Classes.HongKong();

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
                0, // GTA.BasicReproductionNumber,
                0, // GTA.ControlReproductionNumber,
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

            ImmutableList<System.Tuple<System.DateTime, FhirDecimal>> E = export.DayAsymptomaticIndividuals;

            ImmutableList<System.Tuple<System.DateTime, FhirDecimal>> I = export.DaySymptomaticIndividuals;

            ImmutableList<System.Tuple<System.DateTime, FhirDecimal>> J = export.DayIsolatedIndividuals;

            ImmutableList<System.Tuple<System.DateTime, FhirDecimal>> Q = export.DayQuarantinedIndividuals;

            ImmutableList<System.Tuple<System.DateTime, FhirDecimal>> R = export.DayRecoveredIndividuals;

            ImmutableList<System.Tuple<System.DateTime, FhirDecimal>> S = export.DaySusceptibleIndividuals;

            var dayCumulativeProbableCases = export.DayCumulativeProbableCases;

            for (DateTime i = HK.StartDate; i <= HK.EndDate; i = i.AddDays(1))
            {
                System.Diagnostics.Debug.WriteLine(
                    dayCumulativeProbableCases.Where(w => w.Item1 == i).Select(w => w.Item2.Value.Value).SingleOrDefault());
            }
        }
    }
}