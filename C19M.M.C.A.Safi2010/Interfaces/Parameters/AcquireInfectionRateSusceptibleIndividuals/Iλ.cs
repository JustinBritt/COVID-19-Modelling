namespace C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    internal interface Iλ
    {
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
        FhirDecimal GetValue(
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals.Iη η,
            double E,
            double H,
            double I,
            double N,
            double Q,
            double R,
            double S);
    }
}