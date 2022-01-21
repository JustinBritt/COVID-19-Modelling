namespace C19M.M.C.A.Safi2010.Classes.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.QuarantinedIndividuals;

    internal sealed class Q : IQ
    {
        private ILog Log { get; }

        public Q(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdQdt(
            Iα α,
            Iμ μ,
            Iσ σ,
            double E,
            double Q)
        {
            return
                σ.Value.Value.Value
                * 
                (decimal)E
                -
                (α.Value.Value.Value 
                + 
                μ.Value.Value.Value) 
                * 
                (decimal)Q;
        }
    }
}