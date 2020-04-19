namespace C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;

    internal interface IR
    {
        FhirDecimal InitialValue { get; }

        decimal GetdRdt(
            Iδ δ,
            Iμ μ,
            double I,
            double R);
    }
}