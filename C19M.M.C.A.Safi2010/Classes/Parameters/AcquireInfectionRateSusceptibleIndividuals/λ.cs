namespace C19M.M.C.A.Safi2010.Classes.Parameters.AcquireInfectionRateSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals;

    internal sealed class λ : Iλ
    {
        private ILog Log { get; }

        // Constructor
        public λ()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Gets the rate at which susceptible individuals acquire infections.
        /// </summary>
        public FhirDecimal GetValue(
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals.Iη η,
            double H,
            double I,
            double N)
        {
            return new FhirDecimal(
                (decimal)(β.Value.Value.Value * ((decimal)I + η.Value.Value.Value * (decimal)H))
                /
                (decimal)(N));
        }
    }
}