namespace C19M.M.C.Gumel2004.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

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
                context.DiseaseInducedDeathRateSymptomaticIndividuals);

            // d_2
            this.d_2 = new Parameters.DiseaseInducedDeathRateIsolatedIndividuals.d(
                context.DiseaseInducedDeathRateIsolatedIndividuals);

            // p
            this.p = new p(
                context.RecruitmentRateAsymptomaticIndividuals);

            // β
            this.β = new β(
                context.BasicTransmissionCoefficient);

            // γ_1
            this.γ_1 = new Parameters.QuarantineRateAsymptomaticIndividuals.γ(
                context.QuarantineRateAsymptomaticIndividuals);

            // γ_2
            this.γ_2 = new Parameters.IsolationRateSymptomaticIndividuals.γ(
                context.IsolationRateSymptomaticIndividuals);

            // ε_E
            this.ε_E = new Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.ε(
                context.TransmissionCoefficientModificationFactorAsymptomaticIndividuals);

            // ε_J
            this.ε_J = new Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.ε(
                context.TransmissionCoefficientModificationFactorIsolatedIndividuals);

            // ε_Q
            this.ε_Q = new Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.ε(
                context.TransmissionCoefficientModificationFactorQuarantinedIndividuals);

            // κ_1
            this.κ_1 = new Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.κ(
                context.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals);

            // κ_2
            this.κ_2 = new Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.κ(
                context.DevelopmentClinicalSymptomsRateQuarantinedIndividuals);

            // μ
            this.μ = new μ(
                context.NaturalDeathRate);

            // Π
            this.Π = new Π(
                context.NetInflowRateSusceptibleIndividuals);

            // σ_1
            this.σ_1 = new Parameters.RecoveryRateSymptomaticIndividuals.σ(
                context.RecoveryRateSymptomaticIndividuals);

            // σ_2
            this.σ_2 = new Parameters.RecoveryRateIsolatedIndividuals.σ(
               context.RecoveryRateIsolatedIndividuals);

            // Variables

            // E(t)
            this.E = new C19M.M.C.Gumel2004.Classes.Variables.AsymptomaticIndividuals.E(
                context.InitialValueAsymptomaticIndividuals);

            // I(t)
            this.I = new C19M.M.C.Gumel2004.Classes.Variables.SymptomaticIndividuals.I(
                context.InitialValueSymptomaticIndividuals);

            // J(t)
            this.J = new C19M.M.C.Gumel2004.Classes.Variables.IsolatedIndividuals.J(
                context.InitialValueIsolatedIndividuals);

            // N(t)
            this.N = new C19M.M.C.Gumel2004.Classes.Variables.TotalPopulationSize.N(
                context.InitialValueAsymptomaticIndividuals // E(0)
                +
                context.InitialValueSymptomaticIndividuals // I(0)
                +
                context.InitialValueIsolatedIndividuals // J(0)
                +
                context.InitialValueQuarantinedIndividuals // Q(0)
                +
                context.InitialValueRecoveredIndividuals // R(0)
                +
                context.InitialValueSusceptibleIndividuals); // S(0)

            // Q(t)
            this.Q = new C19M.M.C.Gumel2004.Classes.Variables.QuarantinedIndividuals.Q(
                context.InitialValueQuarantinedIndividuals);

            // R(t)
            this.R = new C19M.M.C.Gumel2004.Classes.Variables.RecoveredIndividuals.R(
                context.InitialValueRecoveredIndividuals);

            // S(t)
            this.S = new C19M.M.C.Gumel2004.Classes.Variables.SusceptibleIndividuals.S(
                context.InitialValueSusceptibleIndividuals);
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