namespace C19M.M.C.A.Safi2010.Interfaces.Variables.ExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals;

    internal interface IE
    {
        FhirDecimal InitialValue { get; }

        decimal GetdEdt(
            Iβ β,
            Iη η,
            Iκ κ,
            Iλ λ,
            Iμ μ,
            Iσ σ,
            double E,
            double H,
            double I,
            double N,
            double S);
    }
}