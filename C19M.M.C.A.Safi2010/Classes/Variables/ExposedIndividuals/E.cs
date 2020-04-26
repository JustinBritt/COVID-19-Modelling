namespace C19M.M.C.A.Safi2010.Classes.Variables.ExposedIndividuals
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
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.ExposedIndividuals;

    internal sealed class E : IE
    {
        private ILog Log { get; }

        // Constructor
        public E(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdEdt(
            Iβ β,
            Iη η,
            Iκ κ,
            Iλ λ,
            Iμ μ,
            Iσ σ,
            double E,
            double H,
            double I,
            double N,
            double S)
        {
            return
                λ.GetValue(
                    β,
                    η,
                    H,
                    I,
                    N).Value.Value 
                    * 
                    (decimal)S
                    -
                    (κ.Value.Value.Value + σ.Value.Value.Value + μ.Value.Value.Value) 
                    * 
                    (decimal)E;
        }
    }
}