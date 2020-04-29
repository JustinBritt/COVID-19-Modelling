namespace C19M.M.C.A.Safi2010.Classes.Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Contexts;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Models;

    using C19M.M.C.A.Safi2010.Interfaces.Solutions;
    using MathNet.Numerics.Distributions;

    internal sealed class Equations2_Solution : IEquations2_Solution
    {
        private ILog Log { get; }

        // Constructor
        public Equations2_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayCumulativeDiseaseInducedDeaths.IDayCumulativeDiseaseInducedDeaths DayCumulativeDiseaseInducedDeaths { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayCumulativeProbableCases.IDayCumulativeProbableCases DayCumulativeProbableCases { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayDiseaseInducedDeaths.IDayDiseaseInducedDeaths DayDiseaseInducedDeaths { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayProbableCases.IDayProbableCases DayProbableCases { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayExposedIndividuals.IE E { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayHospitalizedIndividuals.IH H { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayInfectiousIndividuals.II I { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayQuarantinedIndividuals.IQ Q { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DayRecoveredIndividuals.IR R { get; private set; }

        public C19M.M.C.A.Safi2010.Interfaces.Results.DaySusceptibleIndividuals.IS S { get; private set; }

        // TODO: Finish
        public void Solve(
            ISafi2010_Context Safi2010_Context)
        {
            IEquations2_Model equations2_Model = new C19M.M.C.A.Safi2010.Classes.Models.Equations2_Model(
                Safi2010_Context);

            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults =
                MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(
                    MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                        (double)equations2_Model.E.InitialValue.Value.Value,
                        (double)equations2_Model.H.InitialValue.Value.Value,
                        (double)equations2_Model.I.InitialValue.Value.Value,
                        (double)equations2_Model.Q.InitialValue.Value.Value,
                        (double)equations2_Model.R.InitialValue.Value.Value,
                        (double)equations2_Model.S.InitialValue.Value.Value}),
                    equations2_Model.t.NumberDaysAfterStartDate(equations2_Model.t.StartDate).Value.Value,
                    equations2_Model.t.NumberDaysAfterStartDate(equations2_Model.t.EndDate).Value.Value,
                    equations2_Model.t.NumberDaysAfterStartDate(equations2_Model.t.EndDate).Value.Value - equations2_Model.t.NumberDaysAfterStartDate(equations2_Model.t.StartDate).Value.Value + 1,
                    this.f(
                        equations2_Model.t,
                        equations2_Model.α,
                        equations2_Model.β,
                        equations2_Model.γ_1,
                        equations2_Model.γ_2,
                        equations2_Model.δ_1,
                        equations2_Model.δ_2,
                        equations2_Model.η,
                        equations2_Model.κ,
                        equations2_Model.λ,
                        equations2_Model.μ,
                        equations2_Model.Π,
                        equations2_Model.σ,
                        equations2_Model.ϕ,
                        equations2_Model.ψ,
                        equations2_Model.E,
                        equations2_Model.H,
                        equations2_Model.I,
                        equations2_Model.Q,
                        equations2_Model.R,
                        equations2_Model.S));

            // E
            this.E = new C19M.M.C.A.Safi2010.Classes.Calculations.DayExposedIndividuals.E_Calculation().Calculate(
                equations2_Model.t,
                RungeKuttaResults);

            // H
            this.H = new C19M.M.C.A.Safi2010.Classes.Calculations.DayHospitalizedIndividuals.H_Calculation().Calculate(
                equations2_Model.t,
                RungeKuttaResults);

            // I
            this.I = new C19M.M.C.A.Safi2010.Classes.Calculations.DayInfectiousIndividuals.I_Calculation().Calculate(
                equations2_Model.t,
                RungeKuttaResults);

            // Q
            this.Q = new C19M.M.C.A.Safi2010.Classes.Calculations.DayQuarantinedIndividuals.Q_Calculation().Calculate(
                equations2_Model.t,
                RungeKuttaResults);

            // R
            this.R = new C19M.M.C.A.Safi2010.Classes.Calculations.DayRecoveredIndividuals.R_Calculation().Calculate(
                equations2_Model.t,
                RungeKuttaResults);

            // S
            this.S = new C19M.M.C.A.Safi2010.Classes.Calculations.DaySusceptibleIndividuals.S_Calculation().Calculate(
                equations2_Model.t,
                RungeKuttaResults);

            // DayDiseaseInducedDeaths
            this.DayDiseaseInducedDeaths = new C19M.M.C.A.Safi2010.Classes.Calculations.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_Calculation().Calculate(
                equations2_Model.t,
                equations2_Model.δ_1,
                equations2_Model.δ_2,
                this.H,
                this.I);

            // DayProbableCases
            this.DayProbableCases = new C19M.M.C.A.Safi2010.Classes.Calculations.DayProbableCases.DayProbableCases_Calculation().Calculate(
                equations2_Model.t,
                this.H,
                this.I,
                this.Q,
                this.R);

            // DayCumulativeDiseaseInducedDeaths
            this.DayCumulativeDiseaseInducedDeaths = new C19M.M.C.A.Safi2010.Classes.Calculations.DayCumulativeDiseaseInducedDeaths.DayCumulativeDiseaseInducedDeaths_Calculation().Calculate(
                equations2_Model.t,
                this.DayDiseaseInducedDeaths);

            // DayCumulativeProbableCases
        }

        // https://stackoverflow.com/a/55004295
        private Func<double, MathNet.Numerics.LinearAlgebra.Vector<double>, MathNet.Numerics.LinearAlgebra.Vector<double>> f(
            It t,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateQuarantinedIndividuals.Iα α,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EffectiveContactRate.Iβ β,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalRecoveryRateInfectiousIndividuals.Iγ γ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.RecoveryRateHospitalizedIndividuals.Iγ γ_2,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateInfectiousIndividuals.Iδ δ_1,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DiseaseInducedDeathRateHospitalizedIndividuals.Iδ δ_2,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.EfficacyIsolationTreatmentHospitalizedIndividuals.Iη η,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.DevelopmentDiseaseSymptomsRateExposedIndividuals.Iκ κ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.AcquireInfectionRateSusceptibleIndividuals.Iλ λ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.NaturalDeathRate.Iμ μ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.RecruitmentRateSusceptibleIndividuals.IΠ Π,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.QuarantineRateExposedIndividuals.Iσ σ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.HospitalizationRateInfectiousIndividuals.Iϕ ϕ,
            C19M.M.C.A.Safi2010.Interfaces.Parameters.InfectionAcquiredImmunityLossRateRecoveredIndividuals.Iψ ψ,
            C19M.M.C.A.Safi2010.Interfaces.Variables.ExposedIndividuals.IE E,
            C19M.M.C.A.Safi2010.Interfaces.Variables.HospitalizedIndividuals.IH H,
            C19M.M.C.A.Safi2010.Interfaces.Variables.InfectiousIndividuals.II I,
            C19M.M.C.A.Safi2010.Interfaces.Variables.QuarantinedIndividuals.IQ Q,
            C19M.M.C.A.Safi2010.Interfaces.Variables.RecoveredIndividuals.IR R,
            C19M.M.C.A.Safi2010.Interfaces.Variables.SusceptibleIndividuals.IS S)
        {
            return (T, x) =>
            {
                return MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                    (double)E.GetdEdt(
                        β,
                        η,
                        κ,
                        λ,
                        μ,
                        σ,
                        E: x[0],
                        H: x[1],
                        I: x[2],
                        N: x.Sum(),
                        S: x[5]),
                    (double)H.GetdHdt(
                        α,
                        γ_2,
                        δ_2,
                        μ,
                        ϕ,
                        H: x[1],
                        I: x[2],
                        Q: x[3]),
                    (double)I.GetdIdt(
                        γ_1,
                        δ_1,
                        κ,
                        μ,
                        ϕ,
                        E: x[0],
                        I: x[2]),
                    (double)Q.GetdQdt(
                        α,
                        μ,
                        σ,
                        E: x[0],
                        Q: x[3]),
                    (double)R.GetdRdt(
                        γ_1,
                        γ_2,
                        μ,
                        ψ,
                        H: x[1],
                        I: x[2],
                        R: x[4])
                });
            };
        }
    }
}