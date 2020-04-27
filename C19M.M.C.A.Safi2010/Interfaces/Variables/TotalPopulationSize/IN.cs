namespace C19M.M.C.A.Safi2010.Interfaces.Variables.TotalPopulationSize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals;

    internal interface IN
    {
        FhirDecimal InitialValue { get; }

        decimal GetdNdt(
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2,
            Iμ μ,
            IΠ Π,
            double H,
            double I,
            double N);
    }
}