namespace C19M.M.C.A.Safi2010.Interfaces.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals;

    internal interface IS
    {
        FhirDecimal InitialValue { get; }

        decimal GetdSdt(
            Iβ β,
            Iη η,
            Iλ λ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate.Iμ μ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals.IΠ Π,
            Iψ ψ,
            double H,
            double I,
            double N,
            double R,
            double S);
    }
}