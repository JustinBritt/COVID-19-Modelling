namespace C19M.M.C.A.Gumel2006.Classes.Variables.LatentIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals;

    internal sealed class E : IE
    {
        private ILog Log { get; }

        // Constructor
        public E(
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }

        public double GetdEdt(
            Iα α,
            Iβ β,
            Iμ μ,
            Iτ τ,
            double E,
            double I,
            double S,
            double V)
        {
            return
                β.Value * S * I
                +
                (1 - τ.Value) * β.Value * V * I
                -
                α.Value * E
                -
                μ.Value * E;
        }
    }
}