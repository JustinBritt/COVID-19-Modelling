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
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }

        public double GetdNdt(
            Id d,
            Iμ μ,
            IΠ Π,
            double I,
            double N)
        {
            return
                Π.Value
                -
                μ.Value * N
                -
                d.Value * I;
        }
    }
}