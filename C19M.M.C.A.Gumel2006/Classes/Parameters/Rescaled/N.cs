namespace C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled;

    internal sealed class N : IN
    {
        private ILog Log { get; }

        // Constructor
        public N(
            FhirDecimal μ,
            FhirDecimal Π)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = new FhirDecimal(
                μ.Value.Value
                /
                Π.Value.Value);
        }

        public FhirDecimal Value { get; }
    }
}