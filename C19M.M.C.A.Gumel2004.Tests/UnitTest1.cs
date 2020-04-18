namespace C19M.M.C.A.Gumel2004.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            ImmutableList<System.Tuple<System.DateTime, double>> E = export.DayAsymptomaticIndividuals;

            ImmutableList<System.Tuple<System.DateTime, double>> I = export.DaySymptomaticIndividuals;

            ImmutableList<System.Tuple<System.DateTime, double>> J = export.DayIsolatedIndividuals;

            ImmutableList<System.Tuple<System.DateTime, double>> Q = export.DayQuarantinedIndividuals;

            ImmutableList<System.Tuple<System.DateTime, double>> R = export.DayRecoveredIndividuals;

            ImmutableList<System.Tuple<System.DateTime, double>> S = export.DaySusceptibleIndividuals;

            // var cases = E.Last().Item2 + I.Last().Item2 + J.Last().Item2 + Q.Last().Item2 + R.Last().Item2;

            for (DateTime i = HK.StartDate; i <= HK.EndDate; i = i.AddDays(1))
            {
                System.Diagnostics.Debug.WriteLine(
                    E.Where(w => w.Item1 == i).Select(w => w.Item2).SingleOrDefault());
            }
        }
    }
}