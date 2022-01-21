namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2006.Interfaces.Indices;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;

    internal sealed class DayDiseaseInducedDeaths_Calculation : IDayDiseaseInducedDeaths_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayDiseaseInducedDeaths_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayDiseaseInducedDeaths Calculate(
            It t,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate.Id d,
            II I)
        {
            return new C19M.M.C.A.Gumel2006.Classes.Results.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2006.Classes.Calculations.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_ResultElement_Calculation().Calculate(
                        w,
                        d,
                        I))
                .ToImmutableList());
        }
    }
}