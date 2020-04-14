namespace C19M.M.C.A.Gumel2004.Classes.Variables.SymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.A.Gumel2004.Interfaces.Variables.SymptomaticIndividuals;

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
            DateTime t_IndexElement,
            Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1,
            double E,
            double I,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            Iμ μ,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1)
        {
            return
                κ_1.Value * E
                -
                (γ_2.Value.Invoke(t_IndexElement) + d_1.Value + σ_1.Value + μ.Value) * I;
        }
    }
}