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
            double diseaseInducedDeathRateSymptomaticIndividuals,
            double diseaseInducedDeathRateIsolatedIndividuals,
            double recruitmentRateAsymptomaticIndividuals,
            double basicReproductionNumber,
            double controlReproductionNumber)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.DiseaseInducedDeathRateSymptomaticIndividuals = diseaseInducedDeathRateSymptomaticIndividuals;

            this.DiseaseInducedDeathRateIsolatedIndividuals = diseaseInducedDeathRateIsolatedIndividuals;

            this.RecruitmentRateAsymptomaticIndividuals = recruitmentRateAsymptomaticIndividuals;

            this.BasicReproductionNumber = basicReproductionNumber;

            this.ControlReproductionNumber = controlReproductionNumber;
        }

        /// <summary>
        /// Gets the disease-induced death rate for symptomatic individuals.
        /// Parameter: d_1
        /// </summary>
        public double DiseaseInducedDeathRateSymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the disease-induced death rate for isolated individuals.
        /// Parameter: d_2
        /// </summary>
        public double DiseaseInducedDeathRateIsolatedIndividuals { get; }

        /// <summary>
        /// Gets the recruitment rate of asymptomatic individuals per day.
        /// Parameter: p
        /// </summary>
        public double RecruitmentRateAsymptomaticIndividuals { get; }

        /// <summary>
        /// Gets the basic reproduction number.
        /// Parameter: ℛ_0
        /// </summary>
        public double BasicReproductionNumber { get; }

        /// <summary>
        /// Gets the control reproduction number.
        /// </summary>
        public double ControlReproductionNumber { get; }
    }
}