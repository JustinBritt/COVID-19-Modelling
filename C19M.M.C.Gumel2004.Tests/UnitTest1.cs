namespace C19M.M.C.Gumel2004.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using C19M.M.C.Gumel2004;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            C19M.D.Gumel2004.Interfaces.IGTA GTA = new C19M.D.Gumel2004.Classes.GTA();

            C19M.M.C.Gumel2004.Interfaces.Contexts.IGumel2004_Context context = new C19M.M.C.Gumel2004.Classes.Contexts.Gumel2004_Context(
                GTA.DiseaseInducedDeathRateSymptomaticIndividuals,
                GTA.DiseaseInducedDeathRateIsolatedIndividuals,
                GTA.InitialValueAsymptomaticIndividuals,
                GTA.InitialValueSymptomaticIndividuals,
                GTA.InitialValueIsolatedIndividuals,
                GTA.RecruitmentRateAsymptomaticIndividuals,
                GTA.InitialValueQuarantinedIndividuals,
                GTA.InitialValueRecoveredIndividuals,
                0, // GTA.BasicReproductionNumber,
                0, // GTA.ControlReproductionNumber,
                GTA.InitialValueSusceptibleIndividuals,
                GTA.BasicTransmissionCoefficient,
                GTA.QuarantineRateAsymptomaticIndividuals,
                GTA.IsolationRateSymptomaticIndividuals,
                GTA.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                GTA.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                GTA.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                GTA.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                GTA.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                GTA.NaturalDeathRate,
                GTA.NetInflowRateSusceptibleIndividuals,
                GTA.RecoveryRateSymptomaticIndividuals,
                GTA.RecoveryRateIsolatedIndividuals);

            C19M.M.C.Gumel2004.Interfaces.Models.IGumel2004_Model model = new C19M.M.C.Gumel2004.Classes.Models.Gumel2004_Model(
                context);

            C19M.M.C.Gumel2004.Interfaces.Solutions.IGumel2004_Solution solution = new C19M.M.C.Gumel2004.Classes.Solutions.Gumel2004_Solution();

            MathNet.Numerics.LinearAlgebra.Vector<double>[] results = solution.Solve(
                model.d_1,
                model.d_2,
                model.p,
                model.β,
                model.γ_1,
                model.γ_2,
                model.ε_E,
                model.ε_J,
                model.ε_Q,
                model.κ_1,
                model.κ_2,
                model.μ,
                model.Π,
                model.σ_1,
                model.σ_2,
                model.E,
                model.I,
                model.J,
                model.Q,
                model.R,
                model.S);

            for (int i = 0; i <= results.Length - 1; i = i + 1)
            {
                MathNet.Numerics.LinearAlgebra.Vector<double> w = results[i];

                System.Diagnostics.Debug.WriteLine(w[1] + w[2] + w[3]);
            }
        }
    }
}