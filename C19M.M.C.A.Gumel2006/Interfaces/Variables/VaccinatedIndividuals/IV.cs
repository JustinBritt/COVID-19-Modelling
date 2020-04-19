namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IV
    {
        FhirDecimal InitialValue { get; }

        decimal GetdVdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate.Iξ ξ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy.Iτ τ,
            double I,
            double S,
            double V);

        decimal GetdVdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Ip p,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy.Iτ τ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            double I,
            double S,
            double V);
    }
}