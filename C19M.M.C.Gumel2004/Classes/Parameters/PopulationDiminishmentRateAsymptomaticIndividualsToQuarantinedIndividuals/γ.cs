﻿namespace C19M.M.C.Gumel2004.Classes.Parameters.PopulationDiminishmentRateAsymptomaticIndividualsToQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.PopulationDiminishmentRateAsymptomaticIndividualsToQuarantinedIndividuals;

    internal sealed class γ : Iγ
    {
        private ILog Log { get; }

        // Constructor
        public γ(
            double value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the population diminishment rate (symptomatic individuals to quarantined individuals).
        /// </summary>
        public double Value { get; }
    }
}