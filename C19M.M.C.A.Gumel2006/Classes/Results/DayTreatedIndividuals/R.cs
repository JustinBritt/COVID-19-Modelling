﻿namespace C19M.M.C.A.Gumel2006.Classes.Results.DayTreatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayTreatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        public R(
            ImmutableList<IR_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IR_ResultElement> Value { get; }

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