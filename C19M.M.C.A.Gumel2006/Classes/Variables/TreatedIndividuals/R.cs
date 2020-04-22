namespace C19M.M.C.A.Gumel2006.Classes.Variables.TreatedIndividuals
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

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        // Constructor
        public R(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        // Equation (5)
        public decimal GetdRdt(
            Iδ δ,
            Iμ μ,
            double I,
            double R)
        {
            return
                δ.Value.Value.Value * (decimal)I
                -
                μ.Value.Value.Value * (decimal)R;
        }
    }
}