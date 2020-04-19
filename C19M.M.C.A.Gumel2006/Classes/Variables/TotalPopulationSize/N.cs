namespace C19M.M.C.A.Gumel2006.Classes.Variables.TotalPopulationSize
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

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.TotalPopulationSize;

    internal sealed class N : IN
    {
        private ILog Log { get; }

        // Constructor
        public N(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdNdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate.Id d,
            Iμ μ,
            IΠ Π,
            double I,
            double N)
        {
            return
                Π.Value.Value.Value
                -
                μ.Value.Value.Value * (decimal)N
                -
                d.Value.Value.Value * (decimal)I;
        }
    }
}