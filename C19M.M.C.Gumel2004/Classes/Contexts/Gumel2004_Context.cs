namespace C19M.M.C.Gumel2004.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Contexts;

    public sealed class Gumel2004_Context : IGumel2004_Context
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Context(
            double diseaseInducedDeathRateSymptomaticIndividuals)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.DiseaseInducedDeathRateSymptomaticIndividuals = diseaseInducedDeathRateSymptomaticIndividuals;
        }

        // d_1
        public double DiseaseInducedDeathRateSymptomaticIndividuals { get; }
    }
}