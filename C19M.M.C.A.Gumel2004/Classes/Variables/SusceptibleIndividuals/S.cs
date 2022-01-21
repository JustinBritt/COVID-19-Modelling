namespace C19M.M.C.A.Gumel2004.Classes.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Variables.SusceptibleIndividuals;

    internal sealed class S : IS
    {
        private ILog Log { get; }

        // Constructor
        public S(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdSdt(
            FhirDateTime t_IndexElement,
            Iβ β,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q,
            Iμ μ,
            IΠ Π,
            double E,
            double I,
            double J,
            double N,
            double Q,
            double S)
        {
            return
                Π.Value.Value.Value
                -
                (decimal)(S / N) * (β.Value.Value.Value) * ((decimal)I + ε_E.Value.Value.Value * (decimal)E + ε_Q.Value.Invoke(t_IndexElement).Value.Value * (decimal)Q + ε_J.Value.Invoke(t_IndexElement).Value.Value * (decimal)J)
                -
                μ.Value.Value.Value * (decimal)S;
        }
    }
}