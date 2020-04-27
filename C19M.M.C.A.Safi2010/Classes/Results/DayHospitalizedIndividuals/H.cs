namespace C19M.M.C.A.Safi2010.Classes.Results.DayHospitalizedIndividuals
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

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayHospitalizedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayHospitalizedIndividuals;

    internal sealed class H : IH
    {
        private ILog Log { get; }

        // Constructor
        public H(
            ImmutableList<IH_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IH_ResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            FhirDateTime t_IndexElement)
        {
            return this.Value
                .Where(x => x.t_IndexElement.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date == t_IndexElement.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}