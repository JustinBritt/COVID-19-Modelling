﻿namespace C19M.M.C.A.Safi2010.Classes.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals;

    internal sealed class η : Iη
    {
        private ILog Log { get; }

        public η(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the efficacy of isolation or treatment given to hospitalized individuals.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}