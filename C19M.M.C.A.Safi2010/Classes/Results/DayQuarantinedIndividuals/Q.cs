﻿namespace C19M.M.C.A.Safi2010.Classes.Results.DayQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayQuarantinedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayQuarantinedIndividuals;

    internal sealed class Q : IQ
    {
        private ILog Log { get; }

        // Constructor
        public Q(
            ImmutableList<IQ_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IQ_ResultElement> Value { get; }

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