namespace C19M.UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.UI.Imports.Gumel2004;

    public class Gumel2004
    {
        // Constructor
        public Gumel2004()
        {
            // Imports
            C19M.UI.Imports.Gumel2004.Beijing Beijing_Import = new C19M.UI.Imports.Gumel2004.Beijing();

            C19M.UI.Imports.Gumel2004.GreaterTorontoArea GreaterTorontoArea_Import = new C19M.UI.Imports.Gumel2004.GreaterTorontoArea();

            C19M.UI.Imports.Gumel2004.HongKong HongKong_Import = new C19M.UI.Imports.Gumel2004.HongKong();

            C19M.UI.Imports.Gumel2004.Singapore Singapore_Import = new C19M.UI.Imports.Gumel2004.Singapore();

            this.GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths = GreaterTorontoArea_Import.DayCumulativeDiseaseInducedDeaths;

            this.GreaterTorontoArea_DayAsymptomaticIndividuals = GreaterTorontoArea_Import.DayAsymptomaticIndividuals;

            this.GreaterTorontoArea_DaySymptomaticIndividuals = GreaterTorontoArea_Import.DaySymptomaticIndividuals;

            this.GreaterTorontoArea_DayIsolatedIndividuals = GreaterTorontoArea_Import.DayIsolatedIndividuals;

            this.GreaterTorontoArea_DayQuarantinedIndividuals = GreaterTorontoArea_Import.DayQuarantinedIndividuals;

            this.GreaterTorontoArea_DayRecoveredIndividuals = GreaterTorontoArea_Import.DayRecoveredIndividuals;

            this.GreaterTorontoArea_DaySusceptibleIndividuals = GreaterTorontoArea_Import.DaySusceptibleIndividuals;

            this.Beijing_DayCumulativeDiseaseInducedDeaths = Beijing_Import.DayCumulativeDiseaseInducedDeaths;

            this.Beijing_DayAsymptomaticIndividuals = Beijing_Import.DayAsymptomaticIndividuals;

            this.Beijing_DaySymptomaticIndividuals = Beijing_Import.DaySymptomaticIndividuals;

            this.Beijing_DayIsolatedIndividuals = Beijing_Import.DayIsolatedIndividuals;

            this.Beijing_DayQuarantinedIndividuals = Beijing_Import.DayQuarantinedIndividuals;

            this.Beijing_DayRecoveredIndividuals = Beijing_Import.DayRecoveredIndividuals;

            this.Beijing_DaySusceptibleIndividuals = Beijing_Import.DaySusceptibleIndividuals;

            this.HongKong_DayCumulativeDiseaseInducedDeaths = HongKong_Import.DayCumulativeDiseaseInducedDeaths;

            this.HongKong_DayAsymptomaticIndividuals = HongKong_Import.DayAsymptomaticIndividuals;

            this.HongKong_DaySymptomaticIndividuals = HongKong_Import.DaySymptomaticIndividuals;

            this.HongKong_DayIsolatedIndividuals = HongKong_Import.DayIsolatedIndividuals;

            this.HongKong_DayQuarantinedIndividuals = HongKong_Import.DayQuarantinedIndividuals;

            this.HongKong_DayRecoveredIndividuals = HongKong_Import.DayRecoveredIndividuals;

            this.HongKong_DaySusceptibleIndividuals = HongKong_Import.DaySusceptibleIndividuals;

            this.Singapore_DayCumulativeDiseaseInducedDeaths = Singapore_Import.DayCumulativeDiseaseInducedDeaths;

            this.Singapore_DayAsymptomaticIndividuals = Singapore_Import.DayAsymptomaticIndividuals;

            this.Singapore_DaySymptomaticIndividuals = Singapore_Import.DaySymptomaticIndividuals;

            this.Singapore_DayIsolatedIndividuals = Singapore_Import.DayIsolatedIndividuals;

            this.Singapore_DayQuarantinedIndividuals = Singapore_Import.DayQuarantinedIndividuals;

            this.Singapore_DayRecoveredIndividuals = Singapore_Import.DayRecoveredIndividuals;

            this.Singapore_DaySusceptibleIndividuals = Singapore_Import.DaySusceptibleIndividuals;
        }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Beijing_DaySusceptibleIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> GreaterTorontoArea_DaySusceptibleIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> HongKong_DaySusceptibleIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DaySymptomaticIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DayIsolatedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DayQuarantinedIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DayRecoveredIndividuals { get; set; }

        public ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Singapore_DaySusceptibleIndividuals { get; set; }

        // TODO: Update
        public string[] Days => this.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy")).ToArray();

        public decimal[] Beijing_DayCumulativeDiseaseInducedDeaths_Array => this.Beijing_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayAsymptomaticIndividuals_Array => this.Beijing_DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DaySymptomaticIndividuals_Array => this.Beijing_DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayIsolatedIndividuals_Array => this.Beijing_DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayQuarantinedIndividuals_Array => this.Beijing_DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayRecoveredndividuals_Array => this.Beijing_DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DaySusceptibleIndividuals_Array => this.Beijing_DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths_Array => this.GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayAsymptomaticIndividuals_Array => this.GreaterTorontoArea_DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DaySymptomaticIndividuals_Array => this.GreaterTorontoArea_DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayIsolatedIndividuals_Array => this.GreaterTorontoArea_DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayQuarantinedIndividuals_Array => this.GreaterTorontoArea_DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayRecoveredndividuals_Array => this.GreaterTorontoArea_DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DaySusceptibleIndividuals_Array => this.GreaterTorontoArea_DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayCumulativeDiseaseInducedDeaths_Array => this.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayAsymptomaticIndividuals_Array => this.HongKong_DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DaySymptomaticIndividuals_Array => this.HongKong_DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayIsolatedIndividuals_Array => this.HongKong_DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayQuarantinedIndividuals_Array => this.HongKong_DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayRecoveredndividuals_Array => this.HongKong_DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DaySusceptibleIndividuals_Array => this.HongKong_DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayCumulativeDiseaseInducedDeaths_Array => this.Singapore_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayAsymptomaticIndividuals_Array => this.Singapore_DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DaySymptomaticIndividuals_Array => this.Singapore_DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayIsolatedIndividuals_Array => this.Singapore_DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayQuarantinedIndividuals_Array => this.Singapore_DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayRecoveredndividuals_Array => this.Singapore_DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DaySusceptibleIndividuals_Array => this.Singapore_DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();
    }
}