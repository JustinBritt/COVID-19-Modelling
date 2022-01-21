namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayDiseaseInducedDeaths;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayInfectiousIndividuals;

    internal sealed class DayDiseaseInducedDeaths_Calculation : IDayDiseaseInducedDeaths_Calculation
    {
        private ILog Log { get; }

        public DayDiseaseInducedDeaths_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayDiseaseInducedDeaths Calculate(
            It t,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2,
            IH H,
            II I)
        {
            return new C19M.M.C.A.Safi2010.Classes.Results.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths(
                t.Value.Select(
                    w => new C19M.M.C.A.Safi2010.Classes.Calculations.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_ResultElement_Calculation().Calculate(
                        w,
                        δ_1,
                        δ_2,
                        H,
                        I))
                .ToImmutableList());
        }
    }
}