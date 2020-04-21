namespace C19M.M.C.A.Gumel2006.Classes.Solutions
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

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Models;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    internal sealed class DiseaseTransmission_Solution : IDiseaseTransmission_Solution
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseTransmission_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals.IE E { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals.II I { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals.IR R { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals.IS S { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals.IV V { get; private set; }

        // TODO: Finish
        public void Solve(
            IGumel2006_Context Gumel2006_Context)
        {
            IDiseaseTransmission_Model diseaseTransmission_Model = new C19M.M.C.A.Gumel2006.Classes.Models.DiseaseTransmission_Model(
                Gumel2006_Context);

            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults =
                MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(
                    MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                        (double)diseaseTransmission_Model.E.InitialValue.Value.Value,
                        (double)diseaseTransmission_Model.I.InitialValue.Value.Value,
                        (double)diseaseTransmission_Model.R.InitialValue.Value.Value,
                        (double)diseaseTransmission_Model.S.InitialValue.Value.Value,
                        (double)diseaseTransmission_Model.V.InitialValue.Value.Value,}),
                    diseaseTransmission_Model.t.NumberDaysAfterStartDate(diseaseTransmission_Model.t.StartDate).Value.Value,
                    diseaseTransmission_Model.t.NumberDaysAfterStartDate(diseaseTransmission_Model.t.EndDate).Value.Value,
                    diseaseTransmission_Model.t.NumberDaysAfterStartDate(diseaseTransmission_Model.t.EndDate).Value.Value - diseaseTransmission_Model.t.NumberDaysAfterStartDate(diseaseTransmission_Model.t.StartDate).Value.Value + 1,
                    this.f(
                        diseaseTransmission_Model.d,
                        diseaseTransmission_Model.α,
                        diseaseTransmission_Model.β,
                        diseaseTransmission_Model.δ,
                        diseaseTransmission_Model.μ,
                        diseaseTransmission_Model.ξ,
                        diseaseTransmission_Model.Π,
                        diseaseTransmission_Model.τ,
                        diseaseTransmission_Model.E,
                        diseaseTransmission_Model.I,
                        diseaseTransmission_Model.R,
                        diseaseTransmission_Model.S,
                        diseaseTransmission_Model.V));

            // E
            this.E = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayLatentIndividuals.E_Calculation().Calculate(
                diseaseTransmission_Model.t,
                RungeKuttaResults);

            // I
            this.I = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayInfectedIndividuals.I_Calculation().Calculate(
                diseaseTransmission_Model.t,
                RungeKuttaResults);

            // R
            this.R = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayTreatedIndividuals.R_Calculation().Calculate(
                diseaseTransmission_Model.t,
                RungeKuttaResults);

            // S
            this.S = new C19M.M.C.A.Gumel2006.Classes.Calculations.DaySusceptibleIndividuals.S_Calculation().Calculate(
                diseaseTransmission_Model.t,
                RungeKuttaResults);

            // V
            this.V = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayVaccinatedIndividuals.V_Calculation().Calculate(
                diseaseTransmission_Model.t,
                RungeKuttaResults);
        }

        private Func<double, MathNet.Numerics.LinearAlgebra.Vector<double>, MathNet.Numerics.LinearAlgebra.Vector<double>> f(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DiseaseInducedMortalityRate.Id d,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.DevelopmentClinicalSymptomsRate.Iα α,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate.Iδ δ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccinationCoverageRate.Iξ ξ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecruitmentRateSusceptibleHumans.IΠ Π,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.VaccineEfficacy.Iτ τ,
            C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals.IE E,
            C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals.II I,
            C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals.IR R,
            C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals.IS S,
            C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals.IV V)
        {
            return (T, x) =>
            {
                return MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                    (double)E.GetdEdt(
                        α,
                        β,
                        μ,
                        τ,
                        E: x[0],
                        I: x[1],
                        S: x[3],
                        V: x[4]),
                    (double)I.GetdIdt(
                        d,
                        α,
                        δ,
                        μ,
                        E: x[0],
                        I: x[1]),
                    (double)R.GetdRdt(
                        δ,
                        μ,
                        I: x[1],
                        R: x[2]),
                    (double)S.GetdSdt(
                        β,
                        μ,
                        ξ,
                        Π,
                        I: x[1],
                        S: x[3]),
                    (double)V.GetdVdt(
                        β,
                        μ,
                        ξ,
                        τ,
                        I: x[1],
                        S: x[3],
                        V: x[4])
                });
            };
        }
    }
}