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

    internal sealed class γ : Iγ
    {
        private ILog Log { get; }

        // Constructor
        public γ(
            double diseaseInducedMortalityRate,
            double developmentClinicalSymptomsRate,
            double recoveryRate,
            double naturalMortalityRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value =
                developmentClinicalSymptomsRate
                /
                (diseaseInducedMortalityRate + recoveryRate + naturalMortalityRate);
        }

        public double Value { get; }
    }
}