namespace C19M.M.C.A.Gumel2006.Interfaces.Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    internal interface IDiseaseTransmission_Solution
    {
        C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeDiseaseInducedDeaths.IDayCumulativeDiseaseInducedDeaths DayCumulativeDiseaseInducedDeaths { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeProbableCases.IDayCumulativeProbableCases DayCumulativeProbableCases { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DayDiseaseInducedDeaths.IDayDiseaseInducedDeaths DayDiseaseInducedDeaths { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DayProbableCases.IDayProbableCases DayProbableCases { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals.IE E { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals.II I { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals.IR R { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals.IS S { get; }

        C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals.IV V { get; }

        void Solve(
            IGumel2006_Context Gumel2006_Context);
    }
}