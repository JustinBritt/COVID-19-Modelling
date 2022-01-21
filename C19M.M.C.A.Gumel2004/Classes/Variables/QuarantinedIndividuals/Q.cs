namespace C19M.M.C.A.Gumel2004.Classes.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.A.Gumel2004.Interfaces.Variables.QuarantinedIndividuals;

    internal sealed class Q : IQ
    {
        private ILog Log { get; }

        // Constructor
        public Q(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdQdt(
            FhirDateTime t_IndexElement,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ,
            double E,
            double Q)
        {
            return
                γ_1.Value.Invoke(t_IndexElement).Value.Value * (decimal)E
                -
                (κ_2.Value.Value.Value + μ.Value.Value.Value) * (decimal)Q;
        }
    }
}