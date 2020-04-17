namespace C19M.M.C.A.Gumel2004.Tests
{
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

            C19M.M.C.A.Gumel2004.Interfaces.Models.IGumel2004_Model model = new C19M.M.C.A.Gumel2004.Classes.Models.Gumel2004_Model(
                context);

            C19M.M.C.A.Gumel2004.Interfaces.Solutions.IGumel2004_Solution solution = new C19M.M.C.A.Gumel2004.Classes.Solutions.Gumel2004_Solution();

            //MathNet.Numerics.LinearAlgebra.Vector<double>[] results = solution.Solve(
            //    model.t,
            //    model.d_1,
            //    model.d_2,
            //    model.p,
            //    model.β,
            //    model.γ_1,
            //    model.γ_2,
            //    model.ε_E,
            //    model.ε_J,
            //    model.ε_Q,
            //    model.κ_1,
            //    model.κ_2,
            //    model.μ,
            //    model.Π,
            //    model.σ_1,
            //    model.σ_2,
            //    model.E,
            //    model.I,
            //    model.J,
            //    model.Q,
            //    model.R,
            //    model.S);
        }
    }
}