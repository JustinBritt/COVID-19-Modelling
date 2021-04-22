namespace C19M.UI.Models.Gumel2004
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.UI.Imports.Gumel2004;

    public sealed class HongKong
    {
        // Constructor
        public HongKong()
        {
            // Imports
            this.Import = new C19M.UI.Imports.Gumel2004.HongKong();
        }

        public C19M.UI.Imports.Gumel2004.HongKong Import { get; set; }

        // TODO: Update
        public string[] Days => this.Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy")).ToArray();

        public decimal[] DayCumulativeDiseaseInducedDeaths_Array => this.Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayAsymptomaticIndividuals_Array => this.Import.DayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DaySymptomaticIndividuals_Array => this.Import.DaySymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayIsolatedIndividuals_Array => this.Import.DayIsolatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayQuarantinedIndividuals_Array => this.Import.DayQuarantinedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayRecoveredIndividuals_Array => this.Import.DayRecoveredIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DaySusceptibleIndividuals_Array => this.Import.DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();
    }
}