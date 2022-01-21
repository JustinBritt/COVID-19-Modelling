namespace C19M.M.C.A.Gumel2004.Classes.ResultElements.DayIsolatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayIsolatedIndividuals;

    internal sealed class J_ResultElement : IJ_ResultElement
    {
        private ILog Log { get; }

        // Constructor
        public J_ResultElement(
            FhirDateTime t_IndexElement,
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.t_IndexElement = t_IndexElement;

            this.Value = value;
        }

        public FhirDateTime t_IndexElement { get; }

        public FhirDecimal Value { get; }
    }
}