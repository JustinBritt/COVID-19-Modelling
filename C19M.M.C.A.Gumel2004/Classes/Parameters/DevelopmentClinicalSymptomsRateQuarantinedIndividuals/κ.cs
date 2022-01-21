﻿namespace C19M.M.C.A.Gumel2004.Classes.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals;

    internal sealed class κ : Iκ
    {
        private ILog Log { get; }

        public κ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the rate at which quarantined individuals develop clinical symptoms.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}