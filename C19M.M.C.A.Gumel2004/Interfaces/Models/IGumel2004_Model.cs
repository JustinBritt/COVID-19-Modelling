namespace C19M.M.C.A.Gumel2004.Interfaces.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicReproductionNumber;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.ControlReproductionNumber;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecruitmentRateAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.IsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.QuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.RecoveredIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.SymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.TotalPopulationSize;

    internal interface IGumel2004_Model
    {
        It t { get; }

        Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1 { get; }

        Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals.Id d_2 { get; }

        Ip p { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicReproductionNumber.Iℛ ℛ_0 { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.ControlReproductionNumber.Iℛ ℛ_c { get; }

        Iβ β { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1 { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2 { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1 { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2 { get; }

        Iμ μ { get; }

        IΠ Π { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1 { get; }

        C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2 { get; }

        IE E { get; }

        II I { get; }

        IJ J { get; }

        IN N { get; }

        IQ Q { get; }

        IR R { get; }

        IS S { get; }
    }
}