﻿namespace C19M.M.C.A.Gumel2004.Interfaces.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal interface IQ
    {
        double InitialValue { get; }

        double GetdQdt(
            DateTime t_IndexElement,
            double E,
            double Q,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ);
    }
}