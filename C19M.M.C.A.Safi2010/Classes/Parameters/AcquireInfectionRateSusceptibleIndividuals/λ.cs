namespace C19M.M.C.A.Safi2010.Classes.Parameters.AcquireInfectionRateSusceptibleIndividuals
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
        /// <param name="β"></param>
        /// <param name="η"></param>
        /// <param name="E"></param>
        /// <param name="H"></param>
        /// <param name="I"></param>
        /// <param name="N"></param>
        /// <param name="Q"></param>
        /// <param name="R"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public FhirDecimal GetValue(
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals.Iη η,
            double E,
            double H,
            double I,
            double N,
            double Q,
            double R,
            double S)
        {
            return new FhirDecimal(
                (decimal)(β.Value.Value.Value * ((decimal)I + η.Value.Value.Value * (decimal)H))
                /
                (decimal)(E + H + I + N + Q + R + S));
        }
    }
}