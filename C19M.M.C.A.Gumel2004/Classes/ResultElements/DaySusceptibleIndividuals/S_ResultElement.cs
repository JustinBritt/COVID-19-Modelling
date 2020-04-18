namespace C19M.M.C.A.Gumel2004.Classes.ResultElements.DaySusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySusceptibleIndividuals;

    internal sealed class S_ResultElement : IS_ResultElement
    {
        private ILog Log { get; }

        // Constructor
        public S_ResultElement(
            DateTime t_IndexElement,
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.t_IndexElement = t_IndexElement;

            this.Value = value;
        }

        public DateTime t_IndexElement { get; }

        public FhirDecimal Value { get; }
    }
}