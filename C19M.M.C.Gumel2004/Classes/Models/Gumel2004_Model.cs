namespace C19M.M.C.Gumel2004.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Oslo
    using Microsoft.Research.Oslo;

    using C19M.M.C.Gumel2004.Classes.Parameters.BasicReproductionNumber;
    using C19M.M.C.Gumel2004.Classes.Parameters.BasicTransmissionCoefficient;
    using C19M.M.C.Gumel2004.Classes.Parameters.ControlReproductionNumber;
    using C19M.M.C.Gumel2004.Classes.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.DiseaseInducedDeathRateIsolatedIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.IsolationRateSymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.NaturalDeathRate;
    using C19M.M.C.Gumel2004.Classes.Parameters.NetInflowRateSusceptibleIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.QuarantineRateAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.RecoveryRateIsolatedIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.RecoveryRateSymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.RecruitmentRateAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals;
    using C19M.M.C.Gumel2004.Classes.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals;

    using C19M.M.C.Gumel2004.Classes.Vectors;

    using C19M.M.C.Gumel2004.Interfaces.Contexts;

    using C19M.M.C.Gumel2004.Interfaces.Models;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.BasicReproductionNumber;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.ControlReproductionNumber;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.RecruitmentRateAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals;

    using C19M.M.C.Gumel2004.Interfaces.Vectors;

    using C19M.M.C.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Variables.IsolatedIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Variables.QuarantinedIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Variables.RecoveredIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Variables.SymptomaticIndividuals;
    using C19M.M.C.Gumel2004.Interfaces.Variables.TotalPopulationSize;

    internal sealed class Gumel2004_Model : IGumel2004_Model
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Model(
            IGumel2004_Context context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // d_1
            this.d_1 = new Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.d(
                1);

            // d_2
            this.d_2 = new Parameters.DiseaseInducedDeathRateIsolatedIndividuals.d(
                1);

            // E(0)

            // I(0)

            // J(0)

            // p
            this.p = new p(
                2);

            // Q(0)

            // R(0)

            // ℛ_0

            // ℛ_c

            // S(0)

            // β
            this.β = new β(
                1);

            // γ_1
            this.γ_1 = new Parameters.QuarantineRateAsymptomaticIndividuals.γ(
                25);

            // γ_2
            this.γ_2 = new Parameters.IsolationRateSymptomaticIndividuals.γ(
                25);

            // 
            this.ε_E = new Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.ε(
                1);

            // ε_J
            this.ε_J = new Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.ε(
                1);

            // ε_Q
            this.ε_Q = new Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.ε(
                1);

            // κ_1
            this.κ_1 = new Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.κ(
                1);

            // κ_2
            this.κ_2 = new Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.κ(
                1);

            // μ
            this.μ = new μ(
                35);

            // Π
            this.Π = new Π(
                25);

            // σ_1
            this.σ_1 = new Parameters.RecoveryRateSymptomaticIndividuals.σ(
                1);

            // σ_2
            this.σ_2 = new Parameters.RecoveryRateIsolatedIndividuals.σ(
               1);

            // Variables

            // E(t)
            this.E = new C19M.M.C.Gumel2004.Classes.Variables.AsymptomaticIndividuals.E();

            // I(t)
            this.I = new C19M.M.C.Gumel2004.Classes.Variables.SymptomaticIndividuals.I();

            // J(t)
            this.J = new C19M.M.C.Gumel2004.Classes.Variables.IsolatedIndividuals.J();

            // N(t)
            this.N = new C19M.M.C.Gumel2004.Classes.Variables.TotalPopulationSize.N();

            // Q(t)
            this.Q = new C19M.M.C.Gumel2004.Classes.Variables.QuarantinedIndividuals.Q();

            // R(t)
            this.R = new C19M.M.C.Gumel2004.Classes.Variables.RecoveredIndividuals.R();

            // S(t)
            this.S = new C19M.M.C.Gumel2004.Classes.Variables.SusceptibleIndividuals.S();
        }

        public Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1 { get; }

        public Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals.Id d_2 { get; }

        public Ip p { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.BasicReproductionNumber.Iℛ ℛ_0 { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.ControlReproductionNumber.Iℛ ℛ_c { get; }

        public Iβ β { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1 { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2 { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1 { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2 { get; }

        public Iμ μ { get; }

        public IΠ Π { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1 { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2 { get; }

        public IE E { get; }

        public II I { get; }

        public IJ J { get; }

        public IN N { get; }

        public IQ Q { get; }

        public IR R { get; }

        public IS S { get; }
    }
}