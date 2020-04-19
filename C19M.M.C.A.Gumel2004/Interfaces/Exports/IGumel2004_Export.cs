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
        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeProbableCases { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayDiseaseInducedDeaths { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayProbableCases { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayAsymptomaticIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySymptomaticIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayIsolatedIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayQuarantinedIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayRecoveredIndividuals { get; }

        ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; }

        void Solve();
    }
}