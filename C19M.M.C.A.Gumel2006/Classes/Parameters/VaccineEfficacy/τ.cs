namespace C19M.M.C.A.Gumel2006.Classes.Parameters.VaccineEfficacy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    internal sealed class τ : Iτ
    {
        private ILog Log { get; }

        // Constructor
        public τ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}