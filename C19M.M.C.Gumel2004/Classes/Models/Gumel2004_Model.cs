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

            // p

            // ℛ_0

            // ℛ_c

            // β

            // γ_1

            // γ_2

            // κ_1

            // κ_2

            // μ

            // Π

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

        public C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1 { get; }

        public C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_2 { get; }

        public Iμ μ { get; }

        public IΠ Π { get; }

        public IE E { get; }

        public II I { get; }

        public IJ J { get; }

        public IN N { get; }

        public IQ Q { get; }

        public IR R { get; }

        public IS S { get; }
    }
}