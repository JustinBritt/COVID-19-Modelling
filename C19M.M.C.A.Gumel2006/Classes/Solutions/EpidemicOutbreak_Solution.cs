namespace C19M.M.C.A.Gumel2006.Classes.Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Models;

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    internal sealed class EpidemicOutbreak_Solution : IEpidemicOutbreak_Solution
    {
        private ILog Log { get; }

        public EpidemicOutbreak_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals.IE E { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals.II I { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals.IR R { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DaySusceptibleIndividuals.IS S { get; private set; }

        public C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals.IV V { get; private set; }

        public void Solve(
            IGumel2006_Context Gumel2006_Context)
        {
            IEpidemicOutbreak_Model epidemicOutbreak_Model = new C19M.M.C.A.Gumel2006.Classes.Models.EpidemicOutbreak_Model(
                Gumel2006_Context);

            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults =
                MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(
                    MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                        (double)epidemicOutbreak_Model.E.InitialValue.Value.Value,
                        (double)epidemicOutbreak_Model.I.InitialValue.Value.Value,
                        (double)epidemicOutbreak_Model.R.InitialValue.Value.Value,
                        (double)epidemicOutbreak_Model.S.InitialValue.Value.Value,
                        (double)epidemicOutbreak_Model.V.InitialValue.Value.Value,}),
                    epidemicOutbreak_Model.t.NumberDaysAfterStartDate(epidemicOutbreak_Model.t.StartDate).Value.Value,
                    epidemicOutbreak_Model.t.NumberDaysAfterStartDate(epidemicOutbreak_Model.t.EndDate).Value.Value,
                    epidemicOutbreak_Model.t.NumberDaysAfterStartDate(epidemicOutbreak_Model.t.EndDate).Value.Value - epidemicOutbreak_Model.t.NumberDaysAfterStartDate(epidemicOutbreak_Model.t.StartDate).Value.Value + 1,
                    this.f(
                        epidemicOutbreak_Model.N,
                        epidemicOutbreak_Model.p,
                        epidemicOutbreak_Model.β,
                        epidemicOutbreak_Model.γ,
                        epidemicOutbreak_Model.δ,
                        epidemicOutbreak_Model.ε,
                        epidemicOutbreak_Model.μ,
                        epidemicOutbreak_Model.τ,
                        epidemicOutbreak_Model.E,
                        epidemicOutbreak_Model.I,
                        epidemicOutbreak_Model.R,
                        epidemicOutbreak_Model.S,
                        epidemicOutbreak_Model.V));

            // E
            this.E = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayLatentIndividuals.E_Calculation().Calculate(
                epidemicOutbreak_Model.t,
                RungeKuttaResults);

            // I
            this.I = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayInfectedIndividuals.I_Calculation().Calculate(
                epidemicOutbreak_Model.t,
                RungeKuttaResults);

            // R
            this.R = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayTreatedIndividuals.R_Calculation().Calculate(
                epidemicOutbreak_Model.t,
                RungeKuttaResults);

            // S
            this.S = new C19M.M.C.A.Gumel2006.Classes.Calculations.DaySusceptibleIndividuals.S_Calculation().Calculate(
                epidemicOutbreak_Model.t,
                RungeKuttaResults);

            // V
            this.V = new C19M.M.C.A.Gumel2006.Classes.Calculations.DayVaccinatedIndividuals.V_Calculation().Calculate(
                epidemicOutbreak_Model.t,
                RungeKuttaResults);
        }

        private Func<double, MathNet.Numerics.LinearAlgebra.Vector<double>, MathNet.Numerics.LinearAlgebra.Vector<double>> f(
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.IN N,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Ip p,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iβ β,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iγ γ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate.Iδ δ,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.Rescaled.Iε ε,
            C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate.Iμ μ,
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
                        β,
                        γ,
                        ε,
                        τ,
                        E: x[0],
                        I: x[1],
                        S: x[3],
                        V: x[4]),
                    (double)I.GetdIdt(
                        γ,
                        ε,
                        E: x[0],
                        I: x[1]),
                    (double)R.GetdRdt(
                        δ,
                        μ,
                        I: x[1],
                        R: x[2]),
                    (double)S.GetdSdt(
                        N,
                        p,
                        β,
                        ε,
                        I: x[1],
                        S: x[3]),
                    (double)V.GetdVdt(
                        p,
                        β,
                        τ,
                        ε,
                        I: x[1],
                        S: x[3],
                        V: x[4])
                });
            };
        }
    }
}