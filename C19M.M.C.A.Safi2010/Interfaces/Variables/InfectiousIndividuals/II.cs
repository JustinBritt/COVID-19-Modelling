namespace C19M.M.C.A.Safi2010.Interfaces.Variables.InfectiousIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;

    internal interface II
    {
        FhirDecimal InitialValue { get; }

        decimal GetdIdt(
            C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals.Iγ γ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1,
            Iκ κ,
            Iμ μ,
            Iϕ ϕ,
            double E,
            double I);
    }
}