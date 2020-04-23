namespace C19M.M.C.A.Gumel2006.Interfaces.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface IRescaledDiseaseTransmission_Export
    {
        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayLatentIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayInfectedIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayTreatedIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayVaccinatedIndividuals { get; }

        void Solve();
    }
}