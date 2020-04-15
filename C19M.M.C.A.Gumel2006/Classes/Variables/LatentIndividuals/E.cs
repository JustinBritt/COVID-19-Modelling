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

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals;

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

        // TODO: Finish
        public double dEdt(
            Iα α,
            Iβ β,
            Iμ μ,
            Iτ τ,
            double I,
            double S,
            double V)
        {
            return 0;
        }
    }
}