namespace C19M.M.C.A.Gumel2004.Interfaces.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    public interface IGumel2004_Export
    {
        ImmutableList<Tuple<DateTime, FhirDecimal>> DayCumulativeDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DayCumulativeProbableCases { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DayDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DayProbableCases { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DayAsymptomaticIndividuals { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DaySymptomaticIndividuals { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DayIsolatedIndividuals { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DayQuarantinedIndividuals { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DayRecoveredIndividuals { get; }

        ImmutableList<Tuple<DateTime, FhirDecimal>> DaySusceptibleIndividuals { get; }

        void Solve();
    }
}