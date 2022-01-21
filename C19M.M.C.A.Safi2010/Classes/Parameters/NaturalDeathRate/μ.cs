namespace C19M.M.C.A.Safi2010.Classes.Parameters.NaturalDeathRate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;

    internal sealed class μ : Iμ
    {
        private ILog Log { get; }

        public μ(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        /// <summary>
        /// Gets the natural death rate.
        /// </summary>
        public FhirDecimal Value { get; }
    }
}