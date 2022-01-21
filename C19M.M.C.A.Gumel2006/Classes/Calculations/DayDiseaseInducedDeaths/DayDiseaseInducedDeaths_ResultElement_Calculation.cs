namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;

    internal sealed class DayDiseaseInducedDeaths_ResultElement_Calculation : IDayDiseaseInducedDeaths_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayDiseaseInducedDeaths_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate.Id d,
            II I)
        {
            return new C19M.M.C.A.Gumel2006.Classes.ResultElements.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    d.Value.Value.Value
                    *
                    I.GetElementAtAsdecimal(
                        t_IndexElement)));
        }
    }
}