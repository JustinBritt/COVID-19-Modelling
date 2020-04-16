﻿namespace C19M.M.C.A.Gumel2006.Classes.Variables.SusceptibleIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals;

    internal sealed class S : IS
    {
        private ILog Log { get; }

        // Constructor
        public S(
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }
        
        public double GetdSdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            Iμ μ,
            Iξ ξ,
            IΠ Π,
            double I,
            double S)
        {
            return
                Π.Value
                -
                β.Value * S * I
                -
                ξ.Value * S
                -
                μ.Value * S;
        }

        public double GetdSdt(
            IN N,
            Ip p,
            Iβ β,
            Iε ε,
            double I,
            double S)
        {
            return
                -β.Value * S * I
                +
                ε.Value * (N.Value - (S / (1 - p.Value)));
        }
    }
}