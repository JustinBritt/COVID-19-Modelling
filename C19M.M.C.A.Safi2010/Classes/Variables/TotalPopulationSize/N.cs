namespace C19M.M.C.A.Safi2010.Classes.Variables.TotalPopulationSize
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

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.TotalPopulationSize;

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
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2,
            Iμ μ,
            IΠ Π,
            double H,
            double I,
            double N)
        {
            return
                Π.Value.Value.Value
                -
                μ.Value.Value.Value * (decimal)N
                -
                (δ_1.Value.Value.Value * (decimal)I 
                +
                δ_2.Value.Value.Value * (decimal)H);
        }
    }
}