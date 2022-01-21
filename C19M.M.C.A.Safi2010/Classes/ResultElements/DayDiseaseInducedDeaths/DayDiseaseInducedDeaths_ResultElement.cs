namespace C19M.M.C.A.Safi2010.Classes.ResultElements.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayDiseaseInducedDeaths;

    internal sealed class DayDiseaseInducedDeaths_ResultElement : IDayDiseaseInducedDeaths_ResultElement
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths_ResultElement(
            FhirDateTime t_IndexElement,
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.t_IndexElement = t_IndexElement;

            this.Value = value;
        }

        public FhirDateTime t_IndexElement { get; }

        /// <summary>
        /// Gets the number of disease-induced deaths.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}