namespace C19M.M.C.A.Gumel2006.Classes.Exports
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

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Exports;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeProbableCases;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayProbableCases;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    public sealed class DiseaseTransmission_Export : IDiseaseTransmission_Export
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseTransmission_Export(
            IGumel2006_Context Gumel2006_Context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Gumel2006_Context = Gumel2006_Context;

            this.DiseaseTransmission_Solution = new C19M.M.C.A.Gumel2006.Classes.Solutions.DiseaseTransmission_Solution();
        }

        private IGumel2006_Context Gumel2006_Context { get; }

        private IDiseaseTransmission_Solution DiseaseTransmission_Solution { get; }
    }
}