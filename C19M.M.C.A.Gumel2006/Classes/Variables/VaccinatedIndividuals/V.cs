namespace C19M.M.C.A.Gumel2006.Classes.Variables.VaccinatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals;

    internal sealed class V : IV
    {
        private ILog Log { get; }

        // Constructor
        public V(
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }

        public double GetdVdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            Iμ μ,
            Iξ ξ,
            Iτ τ,
            double I,
            double S,
            double V)
        {
            return
                ξ.Value * S
                -
                (1 - τ.Value) * β.Value * V * I
                -
                μ.Value * V;
        }

        // TODO: Finish
        public double GetdVdt(
            Ip p,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iβ β,
            Iτ τ,
            Iε ε,
            double I,
            double S,
            double V)
        {
            return 0;
        }
    }
}