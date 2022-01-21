namespace C19M.D.Gumel2006.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.D.Gumel2006.Interfaces;

    public sealed class Figure2 : IFigure2
    {
        private ILog Log { get; }

        // Constructor
        public Figure2()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Gets the disease-induced mortality rate.
        /// Parameter: d
        /// Units: Per day
        /// </summary>
        public FhirDecimal DiseaseInducedMortalityRate => new FhirDecimal(0.008m);

        /// <summary>
        /// Gets the equilibrium population (without disease).
        /// Parameter: N_o
        /// </summary>
        public FhirDecimal EquilibriumPopulationWithoutDisease => new FhirDecimal(4000000m);

        /// <summary>
        /// Gets the rate of development of clinical symptoms.
        /// Parameter: α
        /// Units: Per day
        /// </summary>
        public FhirDecimal DevelopmentClinicalSymptomsRate => new FhirDecimal(0.125m);

        /// <summary>
        /// Gets the effective contact rate.
        /// Parameter: β
        /// Units: Per day
        /// </summary>
        public FhirDecimal EffectiveContactRate => new FhirDecimal(4.0e-7m);

        /// <summary>
        /// Gets the recovery rate.
        /// Parameter: δ
        /// Units: Per day
        /// </summary>
        public FhirDecimal RecoveryRate => new FhirDecimal(0.04m);

        /// <summary>
        /// Gets the natural mortality rate.
        /// Parameter: μ
        /// Units: Per day
        /// </summary>
        public FhirDecimal NaturalMortalityRate => new FhirDecimal(0.0003m);

        /// <summary>
        /// Gets the vaccination coverage rate.
        /// Parameter: ξ
        /// Units: Per day
        /// </summary>
        public FhirDecimal VaccinationCoverageRate => new FhirDecimal(0.14m);

        /// <summary>
        /// Gets the recruitment rate of susceptible humans.
        /// Parameter: Π
        /// Units: Per day
        /// </summary>
        public FhirDecimal RecruitmentRateSusceptibleHumans => new FhirDecimal(146m);

        /// <summary>
        /// Gets the efficacy of the vaccine.
        /// Parameter: τ
        /// </summary>
        public FhirDecimal VaccineEfficacy => new FhirDecimal(0.8m);
    }
}