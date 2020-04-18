namespace C19M.M.C.A.Gumel2004.Classes.ResultElements.DayProbableCases
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

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayProbableCases;

    internal sealed class DayProbableCases_ResultElement : IDayProbableCases_ResultElement
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases_ResultElement(
            DateTime t_IndexElement,
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.t_IndexElement = t_IndexElement;

            this.Value = value;
        }

        public DateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the number of probable cases.
        /// </summary>
        public double Value { get; }
    }
}