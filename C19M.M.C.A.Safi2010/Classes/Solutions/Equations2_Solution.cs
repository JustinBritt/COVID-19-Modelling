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

    internal sealed class Equations2_Solution : IEquations2_Solution
    {
        private ILog Log { get; }

        // Constructor
        public Equations2_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public void Solve(
            ISafi2010_Context Safi2010_Context)
        {
            IEquations2_Model Equations2_Model = new C19M.M.C.A.Safi2010.Classes.Models.Equations2_Model(
                Safi2010_Context);

            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults =
                MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(
                    MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                        (double)Equations2_Model.E.InitialValue.Value.Value,
                        (double)Equations2_Model.H.InitialValue.Value.Value,
                        (double)Equations2_Model.I.InitialValue.Value.Value,
                        (double)Equations2_Model.Q.InitialValue.Value.Value,
                        (double)Equations2_Model.R.InitialValue.Value.Value,
                        (double)Equations2_Model.S.InitialValue.Value.Value}),
                    Equations2_Model.t.NumberDaysAfterStartDate(Equations2_Model.t.StartDate).Value.Value,
                    Equations2_Model.t.NumberDaysAfterStartDate(Equations2_Model.t.EndDate).Value.Value,
                    Equations2_Model.t.NumberDaysAfterStartDate(Equations2_Model.t.EndDate).Value.Value - Equations2_Model.t.NumberDaysAfterStartDate(Equations2_Model.t.StartDate).Value.Value + 1,
                    this.f(
                        Equations2_Model.t,
                        Equations2_Model.α,
                        Equations2_Model.β,
                        Equations2_Model.γ_1,
                        Equations2_Model.γ_2,
                        Equations2_Model.δ_1,
                        Equations2_Model.δ_2,
                        Equations2_Model.η,
                        Equations2_Model.κ,
                        Equations2_Model.λ,
                        Equations2_Model.μ,
                        Equations2_Model.Π,
                        Equations2_Model.σ,
                        Equations2_Model.ϕ,
                        Equations2_Model.ψ,
                        Equations2_Model.E,
                        Equations2_Model.H,
                        Equations2_Model.I,
                        Equations2_Model.Q,
                        Equations2_Model.R,
                        Equations2_Model.S));
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
                        S: x[5])
                });
            };
        }
    }
}