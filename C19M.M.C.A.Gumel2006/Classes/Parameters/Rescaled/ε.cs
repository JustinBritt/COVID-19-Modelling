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

    internal sealed class ε : Iε
    {
        private ILog Log { get; }

        // Constructor
        public ε(
            FhirDecimal diseaseInducedMortalityRate,
            FhirDecimal recoveryRate,
            FhirDecimal naturalMortalityRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = new FhirDecimal(
                naturalMortalityRate.Value.Value
                /
                (diseaseInducedMortalityRate.Value.Value + recoveryRate.Value.Value + naturalMortalityRate.Value.Value));
        }

        // Constructor
        public ε(
            FhirDecimal value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public FhirDecimal Value { get; }
    }
}