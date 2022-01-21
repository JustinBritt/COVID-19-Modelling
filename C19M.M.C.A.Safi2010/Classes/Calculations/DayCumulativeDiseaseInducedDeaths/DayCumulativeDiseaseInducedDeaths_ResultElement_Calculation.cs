namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayDiseaseInducedDeaths;

    internal sealed class DayCumulativeDiseaseInducedDeaths_ResultElement_Calculation : IDayCumulativeDiseaseInducedDeaths_ResultElement_Calculation
    {
        private ILog Log { get; }

        public DayCumulativeDiseaseInducedDeaths_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayCumulativeDiseaseInducedDeaths_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            IDayDiseaseInducedDeaths dayDiseaseInducedDeaths)
        {
            return new C19M.M.C.A.Safi2010.Classes.ResultElements.DayCumulativeDiseaseInducedDeaths.DayCumulativeDiseaseInducedDeaths_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    t.Value
                    .Where(w => w >= t.StartDate && w <= t_IndexElement)
                    .Select(w => dayDiseaseInducedDeaths.GetElementAtAsdecimal(w))
                    .Sum()));
        }
    }
}