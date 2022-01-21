namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayInfectiousIndividuals;

    internal sealed class DayDiseaseInducedDeaths_ResultElement_Calculation : IDayDiseaseInducedDeaths_ResultElement_Calculation
    {
        private ILog Log { get; }

        public DayDiseaseInducedDeaths_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayDiseaseInducedDeaths_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2,
            IH H,
            II I)
        {
            return new C19M.M.C.A.Safi2010.Classes.ResultElements.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    δ_1.Value.Value.Value
                    *
                    I.GetElementAtAsdecimal(
                        t_IndexElement)
                    +
                    δ_2.Value.Value.Value
                    *
                    H.GetElementAtAsdecimal(
                        t_IndexElement)));
        }
    }
}