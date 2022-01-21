namespace C19M.M.C.A.Gumel2006.Classes.Parameters.RecoveryRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;

    internal sealed class δ : Iδ
    {
        private ILog Log { get; }

        // Constructor
        public δ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the recovery rate.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}