﻿namespace C19M.UI.Models.Gumel2006
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed class Figure6Model
    {
        public Figure6Model()
        {
            // Imports
            this.Import = new C19M.UI.Imports.Gumel2006.Figure6_DiseaseTransmission();
        }

        public C19M.UI.Imports.Gumel2006.Figure6_DiseaseTransmission Import { get; set; }

        // TODO: Update
        public string[] Days => this.Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date.ToString("MMM dd yyyy")).ToArray();

        public decimal[] DayCumulativeDiseaseInducedDeaths => this.Import.DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayCumulativeProbableCases => this.Import.DayCumulativeProbableCases.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayDiseaseInducedDeaths => this.Import.DayDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayProbableCases => this.Import.DayProbableCases.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayLatentIndividuals => this.Import.DayLatentIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayInfectedIndividuals => this.Import.DayInfectedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayTreatedIndividuals => this.Import.DayTreatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DaySusceptibleIndividuals => this.Import.DaySusceptibleIndividuals.Select(w => w.Item2.Value.Value).ToArray();

        public decimal[] DayVaccinatedIndividuals => this.Import.DayVaccinatedIndividuals.Select(w => w.Item2.Value.Value).ToArray();
    }
}