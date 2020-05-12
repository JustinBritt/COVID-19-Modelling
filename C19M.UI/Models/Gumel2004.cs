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
            this.Beijing_Import = new C19M.UI.Imports.Gumel2004.Beijing();

            this.GreaterTorontoArea_Import = new C19M.UI.Imports.Gumel2004.GreaterTorontoArea();

            this.HongKong_Import = new C19M.UI.Imports.Gumel2004.HongKong();

            this.Singapore_Import = new C19M.UI.Imports.Gumel2004.Singapore();
        }

        public C19M.UI.Imports.Gumel2004.Beijing Beijing_Import { get; set; }

        public C19M.UI.Imports.Gumel2004.GreaterTorontoArea GreaterTorontoArea_Import { get; set; }

        public C19M.UI.Imports.Gumel2004.HongKong HongKong_Import { get; set; }

        public C19M.UI.Imports.Gumel2004.Singapore Singapore_Import { get; set; }

        // TODO: Update
        public string[] Days => this.HongKong_Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy")).ToArray();

        public decimal[] Beijing_DayCumulativeDiseaseInducedDeaths_Array => this.Beijing_Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayAsymptomaticIndividuals_Array => this.Beijing_Import.DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DaySymptomaticIndividuals_Array => this.Beijing_Import.DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayIsolatedIndividuals_Array => this.Beijing_Import.DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayQuarantinedIndividuals_Array => this.Beijing_Import.DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DayRecoveredndividuals_Array => this.Beijing_Import.DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Beijing_DaySusceptibleIndividuals_Array => this.Beijing_Import.DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayCumulativeDiseaseInducedDeaths_Array => this.GreaterTorontoArea_Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayAsymptomaticIndividuals_Array => this.GreaterTorontoArea_Import.DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DaySymptomaticIndividuals_Array => this.GreaterTorontoArea_Import.DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayIsolatedIndividuals_Array => this.GreaterTorontoArea_Import.DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayQuarantinedIndividuals_Array => this.GreaterTorontoArea_Import.DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DayRecoveredndividuals_Array => this.GreaterTorontoArea_Import.DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] GreaterTorontoArea_DaySusceptibleIndividuals_Array => this.GreaterTorontoArea_Import.DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayCumulativeDiseaseInducedDeaths_Array => this.HongKong_Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayAsymptomaticIndividuals_Array => this.HongKong_Import.DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DaySymptomaticIndividuals_Array => this.HongKong_Import.DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayIsolatedIndividuals_Array => this.HongKong_Import.DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayQuarantinedIndividuals_Array => this.HongKong_Import.DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DayRecoveredndividuals_Array => this.HongKong_Import.DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] HongKong_DaySusceptibleIndividuals_Array => this.HongKong_Import.DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayCumulativeDiseaseInducedDeaths_Array => this.Singapore_Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayAsymptomaticIndividuals_Array => this.Singapore_Import.DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DaySymptomaticIndividuals_Array => this.Singapore_Import.DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayIsolatedIndividuals_Array => this.Singapore_Import.DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayQuarantinedIndividuals_Array => this.Singapore_Import.DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DayRecoveredndividuals_Array => this.Singapore_Import.DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] Singapore_DaySusceptibleIndividuals_Array => this.Singapore_Import.DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();
    }
}