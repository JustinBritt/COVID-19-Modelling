namespace C19M.M.C.A.Gumel2006.Classes.Variables.InfectedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals;

    internal sealed class I : II
    {
        private ILog Log { get; }

        // Constructor
        public I(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdIdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate.Id d,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate.Iα α,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate.Iδ δ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            double E,
            double I)
        {
            return
                α.Value.Value.Value * (decimal)E
                -
                δ.Value.Value.Value * (decimal)I
                -
                d.Value.Value.Value * (decimal)I
                -
                μ.Value.Value.Value * (decimal)I;
        }

        public decimal GetdIdt(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iγ γ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            double E,
            double I)
        {
            return
                γ.Value.Value.Value * (decimal)E
                -
                (1m + ε.Value.Value.Value) * (decimal)I;
        }
    }
}