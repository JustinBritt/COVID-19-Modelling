﻿namespace C19M.M.C.A.Gumel2004.Classes.Variables.RecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.A.Gumel2004.Interfaces.Variables.RecoveredIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        // Constructor
        public R(
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }

        public double GetdRdt(
            Iμ μ,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2,
            double I,
            double J,
            double R)
        {
            return
                σ_1.Value * I
                +
                σ_2.Value * J
                -
                μ.Value * R;
        }
    }
}