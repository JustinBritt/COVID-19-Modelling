namespace C19M.M.C.A.Safi2010.Classes.Variables.InfectiousIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate;

    using C19M.M.C.A.Safi2010.Interfaces.Variables.InfectiousIndividuals;

    internal sealed class I : II
    {
        private ILog Log { get; }

        public I(
            FhirDecimal initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public FhirDecimal InitialValue { get; }

        public decimal GetdIdt(
            C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals.Iγ γ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1,
            Iκ κ,
            Iμ μ,
            Iϕ ϕ,
            double E,
            double I)
        {
            return
                κ.Value.Value.Value * (decimal)E
                -
                (γ_1.Value.Value.Value + ϕ.Value.Value.Value + μ.Value.Value.Value + δ_1.Value.Value.Value) * (decimal)I;
        }
    }
}