namespace C19M.M.C.A.Safi2010.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Contexts;

    public sealed class Safi2010_Context : ISafi2010_Context
    {
        private ILog Log { get; }

        // Constructor
        public Safi2010_Context(
            FhirDecimal quarantineRateExposedIndividuals,
            FhirDecimal effectiveContactRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.QuarantineRateExposedIndividuals = quarantineRateExposedIndividuals;

            this.EffectiveContactRate = effectiveContactRate;
        }

        public FhirDecimal QuarantineRateExposedIndividuals { get; }

        public FhirDecimal EffectiveContactRate { get; }
    }
}