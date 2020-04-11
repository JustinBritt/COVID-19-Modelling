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

            // d_2

            // E(0)

            // I(0)

            // J(0)

            // p

            // Q(0)

            // R(0)

            // ℛ_0

            // ℛ_c

            // S(0)

            // β

            // γ_1

            // γ_2

            // ε_E

            // ε_J

            // ε_Q

            // κ_1

            // κ_2

            // μ

            // Π

            // σ_1

            // σ_2

            // Variables

            // E(t)

            // I(t)

            // J(t)

            // N(t)

            // Q(t)

            // R(t)

            // S(t)
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

        // https://stackoverflow.com/a/55004295
        // TODO: Move
        public Func<double, Vector, Vector> GetSystemRightPartsVectorFunction(
            Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1,
            Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals.Id d_2,
            Ip p,
            Iβ β,
            C19M.M.C.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J,
            C19M.M.C.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ,
            IΠ Π,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2,
            C19M.M.C.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals.IE E,
            C19M.M.C.Gumel2004.Interfaces.Variables.SymptomaticIndividuals.II I,
            C19M.M.C.Gumel2004.Interfaces.Variables.IsolatedIndividuals.IJ J,
            C19M.M.C.Gumel2004.Interfaces.Variables.QuarantinedIndividuals.IQ Q,
            C19M.M.C.Gumel2004.Interfaces.Variables.RecoveredIndividuals.IR R,
            C19M.M.C.Gumel2004.Interfaces.Variables.SusceptibleIndividuals.IS S)
        {
            // E: 0, I: 1, J: 2, Q: 3, R: 4, S: 5, N: sum
            return (t, x) =>
            {
                return new Vector(
                    E.GetdEdt(
                        E: x[0],
                        I: x[1],
                        J: x[2],
                        N: x.Sum,
                        p,
                        Q: x[3],
                        S: x[5],
                        β,
                        γ_1,
                        γ_2,
                        ε_E,
                        ε_J,
                        ε_Q,
                        κ_1,
                        μ),
                    I.GetdIdt(
                        d_1,
                        E: x[0],
                        I: x[1],
                        γ_2,
                        κ_1,
                        μ,
                        σ_1),
                    J.GetdJdt(
                        d_2,
                        I: x[1],
                        J: x[2],
                        Q: x[3],
                        γ_2,
                        κ_2,
                        μ,
                        σ_2),
                    Q.GetdQdt(
                        E: x[0],
                        Q: x[3],
                        γ_1,
                        κ_2,
                        μ),
                    R.GetdRdt(
                        I: x[1],
                        J: x[2],
                        R: x[4],
                        μ,
                        σ_1,
                        σ_2),
                    S.GetdSdt(
                        E: x[0],
                        I: x[1],
                        J: x[2],
                        N: x.Sum,
                        Q: x[3],
                        S: x[5],
                        β,
                        ε_E,
                        ε_J,
                        ε_Q,
                        μ,
                        Π));
            };
        }
    }
}