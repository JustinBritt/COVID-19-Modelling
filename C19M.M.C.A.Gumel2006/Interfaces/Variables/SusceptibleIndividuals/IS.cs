﻿namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;

    internal interface IS
    {
        FhirDecimal InitialValue { get; }

        decimal GetdSdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate.Iξ ξ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans.IΠ Π,
            double I,
            double S);

        decimal GetdSdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.IN N,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Ip p,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            double I,
            double S);
    }
}