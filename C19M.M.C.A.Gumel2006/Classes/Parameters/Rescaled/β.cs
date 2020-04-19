namespace C19M.M.C.A.Gumel2006.Classes.Parameters.Rescaled
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled;

    internal sealed class β : Iβ
    {
        private ILog Log { get; }

        // Constructor
        public β(
            double diseaseInducedMortalityRate,
            double effectiveContactRate,
            double recoveryRate,
            double naturalMortalityRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value =
                effectiveContactRate
                /
                (diseaseInducedMortalityRate + recoveryRate + naturalMortalityRate);
        }

        public double Value { get; }
    }
}