namespace C19M.M.C.Gumel2004.Classes.Variables.SymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Oslo
    using Microsoft.Research.Oslo;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.Gumel2004.Interfaces.Variables.SymptomaticIndividuals;

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

        /// <summary>
        /// Gets dI/dt.
        /// </summary>
        /// <param name="d_1"></param>
        /// <param name="E"></param>
        /// <param name="I"></param>
        /// <param name="γ_2"></param>
        /// <param name="κ_1"></param>
        /// <param name="μ"></param>
        /// <param name="σ_1"></param>
        /// <returns></returns>
        public double GetdIdt(
            Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1,
            double E,
            double I,
            C19M.M.C.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            Iμ μ,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1)
        {
            return
                κ_1.Value * E
                -
                (γ_2.Value + d_1.Value + σ_1.Value + μ.Value) * I;
        }
    }
}