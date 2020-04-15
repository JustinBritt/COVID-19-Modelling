﻿namespace C19M.M.C.A.Gumel2006.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    public sealed class Gumel2006_Context : IGumel2006_Context
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2006_Context(
            double diseaseInducedMortalityRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.DiseaseInducedMortalityRate = diseaseInducedMortalityRate;
        }

        /// <summary>
        /// Gets the disease-induced mortality rate.
        /// Parameter: d
        /// Units: Per day
        /// </summary>
        public double DiseaseInducedMortalityRate { get; }
    }
}