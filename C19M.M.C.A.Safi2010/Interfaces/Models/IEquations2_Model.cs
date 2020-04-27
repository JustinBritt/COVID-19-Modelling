namespace C19M.M.C.A.Safi2010.Interfaces.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.ExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.HospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.InfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.QuarantinedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.RecoveredIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Variables.TotalPopulationSize;

    internal interface IEquations2_Model
    {
        It t { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals.Iα α { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate.Iβ β { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals.Iγ γ_1 { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals.Iγ γ_2 { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1 { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2 { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals.Iη η { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals.Iκ κ { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals.Iλ λ { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate.Iμ μ { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals.IΠ Π { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals.Iσ σ { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals.Iϕ ϕ { get; }

        C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals.Iψ ψ { get; }

        IE E { get; }

        IH H { get; }

        II I { get; }

        IN N { get; }

        IQ Q { get; }

        IR R { get; }

        IS S { get; }
    }
}