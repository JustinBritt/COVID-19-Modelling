namespace C19M.M.C.A.Gumel2006.Classes.Variables.InfectedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals;

    internal sealed class I : II
    {
        private ILog Log { get; }

        // Constructor
        public I(
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }

        public double GetdIdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate.Id d,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate.Iα α,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate.Iδ δ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            double E,
            double I)
        {
            return
                α.Value * E
                -
                δ.Value * I
                -
                d.Value * I
                -
                μ.Value * I;
        }

        public double GetdIdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iγ γ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            double E,
            double I)
        {
            return
                γ.Value * E
                -
                (1 + ε.Value) * I;
        }
    }
}