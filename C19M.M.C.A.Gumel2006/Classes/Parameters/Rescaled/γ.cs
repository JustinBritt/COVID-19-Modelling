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

    internal sealed class γ : Iγ
    {
        private ILog Log { get; }

        public γ(
            FhirDecimal diseaseInducedMortalityRate,
            FhirDecimal developmentClinicalSymptomsRate,
            FhirDecimal recoveryRate,
            FhirDecimal naturalMortalityRate)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = new FhirDecimal(
                developmentClinicalSymptomsRate.Value.Value
                /
                (diseaseInducedMortalityRate.Value.Value + recoveryRate.Value.Value + naturalMortalityRate.Value.Value));
        }

        public FhirDecimal Value { get; }
    }
}