namespace C19M.M.C.A.Gumel2004.Interfaces.Variables.QuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;

    internal interface IQ
    {
        FhirDecimal InitialValue { get; }

        decimal GetdQdt(
            FhirDateTime t_IndexElement,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ,
            double E,
            double Q);
    }
}