namespace C19M.M.C.Gumel2004.Interfaces.Variables.SymptomaticIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal interface II
    {
        double InitialValue { get; }

        double GetdIdt(
            DateTime t_IndexElement,
            Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1,
            double E,
            double I,
            C19M.M.C.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            Iμ μ,
            C19M.M.C.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1);
    }
}