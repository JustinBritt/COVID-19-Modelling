namespace C19M.M.C.A.Safi2010.Interfaces.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals;

    internal interface IQ
    {
        FhirDecimal InitialValue { get; }

        decimal GetdQdt(
            Iα α,
            Iμ μ,
            Iσ σ,
            double E,
            double Q);
    }
}