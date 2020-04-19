namespace C19M.M.C.A.Gumel2004.Classes.Variables.AsymptomaticIndividuals
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

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecruitmentRateAsymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals;

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
            FhirDateTime t_IndexElement,
            Ip p,
            Iβ β,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            Iμ μ,
            double E,
            double I,
            double J,
            double N,
            double Q,
            double S)
        {
            return 
                p.Value.Value.Value
                +
                (decimal)(S / N) * (β.Value.Value.Value) * ((decimal)I + ε_E.Value.Value.Value * (decimal)E + ε_Q.Value.Invoke(t_IndexElement).Value.Value * (decimal)Q + ε_J.Value.Invoke(t_IndexElement).Value.Value * (decimal)J)
                -
                (γ_1.Value.Invoke(t_IndexElement).Value.Value + κ_1.Value.Value.Value + μ.Value.Value.Value) * (decimal)E;
        }
    }
}