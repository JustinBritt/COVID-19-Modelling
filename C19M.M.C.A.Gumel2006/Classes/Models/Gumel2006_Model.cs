namespace C19M.M.C.A.Gumel2006.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Classes.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.EquilibriumPopulationWithoutDisease;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.RecoveryRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.RecruitmentRateSusceptibleHumans;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.VaccinationCoverageRate;
    using C19M.M.C.A.Gumel2006.Classes.Parameters.VaccineEfficacy;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Models;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.EquilibriumPopulationWithoutDisease;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals;

    internal sealed class Gumel2006_Model : IGumel2006_Model
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2006_Model(
            IGumel2006_Context context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // d

            // α

            // β

            // δ

            // μ

            // ξ

            // Π

            // τ

            // Variables

            // E(t)

            // I(t)

            // N(t)

            // R(t)

            // S(t)

            // V(t)
        }

        public Id d { get; }

        public Iα α { get; }

        public Iβ β { get; }

        public Iδ δ { get; }

        public Iμ μ { get; }

        public Iξ ξ { get; }

        public IΠ Π { get; }

        public Iτ τ { get; }

        public IE E { get; }

        public II I { get; }

        public IR R { get; }

        public IS S { get; }

        public IV V { get; }
    }
}