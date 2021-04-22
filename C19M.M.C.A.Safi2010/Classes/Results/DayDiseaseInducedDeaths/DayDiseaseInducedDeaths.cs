﻿namespace C19M.M.C.A.Safi2010.Classes.Results.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayDiseaseInducedDeaths;

    internal sealed class DayDiseaseInducedDeaths : IDayDiseaseInducedDeaths
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths(
            ImmutableList<IDayDiseaseInducedDeaths_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IDayDiseaseInducedDeaths_ResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            FhirDateTime t_IndexElement)
        {
            return this.Value
                .Where(x => x.t_IndexElement.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date == t_IndexElement.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}