﻿namespace C19M.M.C.A.Gumel2004.Classes.Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicReproductionNumber;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.ControlReproductionNumber;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NaturalDeathRate;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.NetInflowRateSusceptibleIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecruitmentRateAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayAsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    using C19M.M.C.A.Gumel2004.Interfaces.Solutions;

    using C19M.M.C.A.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.IsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.QuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.RecoveredIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.SymptomaticIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Variables.TotalPopulationSize;

    internal sealed class Gumel2004_Solution : IGumel2004_Solution
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayCumulativeDiseaseInducedDeaths DayCumulativeDiseaseInducedDeaths { get; private set; }

        public IDayDiseaseInducedDeaths DayDiseaseInducedDeaths { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayAsymptomaticIndividuals.IE E { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals.II I { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals.IJ J { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals.IQ Q { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals.IR R { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals.IS S { get; private set; }

        public double Solve(
            It t,
            Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1,
            Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals.Id d_2,
            Ip p,
            Iβ β,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ,
            IΠ Π,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals.IE E,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.SymptomaticIndividuals.II I,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.IsolatedIndividuals.IJ J,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.QuarantinedIndividuals.IQ Q,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.RecoveredIndividuals.IR R,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.SusceptibleIndividuals.IS S)
        {
            MathNet.Numerics.LinearAlgebra.Vector<double>[] results = 
                MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(
                    MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                        E.InitialValue,
                        I.InitialValue,
                        J.InitialValue,
                        Q.InitialValue,
                        R.InitialValue,
                        S.InitialValue}),
                    t.NumberDaysAfterStartDate(t.StartDate),
                    t.NumberDaysAfterStartDate(t.EndDate),
                    t.NumberDaysAfterStartDate(t.EndDate) - t.NumberDaysAfterStartDate(t.StartDate) + 1,
                    this.f(
                        t,
                        d_1,
                        d_2,
                        p,
                        β,
                        γ_1,
                        γ_2,
                        ε_E,
                        ε_J,
                        ε_Q,
                        κ_1,
                        κ_2,
                        μ,
                        Π,
                        σ_1,
                        σ_2,
                        E,
                        I,
                        J,
                        Q,
                        R,
                        S));

            List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayAsymptomaticIndividuals.IE_ResultElement> E_res = new List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayAsymptomaticIndividuals.IE_ResultElement>();

            List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySymptomaticIndividuals.II_ResultElement> I_res = new List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySymptomaticIndividuals.II_ResultElement>();

            List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayIsolatedIndividuals.IJ_ResultElement> J_res = new List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayIsolatedIndividuals.IJ_ResultElement>();

            List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayQuarantinedIndividuals.IQ_ResultElement> Q_res = new List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayQuarantinedIndividuals.IQ_ResultElement>();

            List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayRecoveredIndividuals.IR_ResultElement> R_res = new List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayRecoveredIndividuals.IR_ResultElement>();

            List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySusceptibleIndividuals.IS_ResultElement> S_res = new List<C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DaySusceptibleIndividuals.IS_ResultElement>();

            for (DateTime i = t.StartDate; i <= t.EndDate; i = i.AddDays(1))
            {
                E_res.Add(
                    new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayAsymptomaticIndividuals.E_ResultElement(
                        i,
                        results[t.NumberDaysAfterStartDate.Invoke(i)][0]));

                I_res.Add(
                    new C19M.M.C.A.Gumel2004.Classes.ResultElements.DaySymptomaticIndividuals.I_ResultElement(
                        i,
                        results[t.NumberDaysAfterStartDate.Invoke(i)][1]));

                J_res.Add(
                    new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayIsolatedIndividuals.J_ResultElement(
                        i,
                        results[t.NumberDaysAfterStartDate.Invoke(i)][2]));

                Q_res.Add(
                    new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayQuarantinedIndividuals.Q_ResultElement(
                        i,
                        results[t.NumberDaysAfterStartDate.Invoke(i)][3]));

                R_res.Add(
                    new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayRecoveredIndividuals.R_ResultElement(
                        i,
                        results[t.NumberDaysAfterStartDate.Invoke(i)][4]));

                S_res.Add(
                    new C19M.M.C.A.Gumel2004.Classes.ResultElements.DaySusceptibleIndividuals.S_ResultElement(
                        i,
                        results[t.NumberDaysAfterStartDate.Invoke(i)][5]));
            }

            // E
            this.E = new C19M.M.C.A.Gumel2004.Classes.Results.DayAsymptomaticIndividuals.E(
                E_res.ToImmutableList());

            // I
            this.I = new C19M.M.C.A.Gumel2004.Classes.Results.DaySymptomaticIndividuals.I(
                I_res.ToImmutableList());

            // J
            this.J = new C19M.M.C.A.Gumel2004.Classes.Results.DayIsolatedIndividuals.J(
                J_res.ToImmutableList());

            // Q
            this.Q = new C19M.M.C.A.Gumel2004.Classes.Results.DayQuarantinedIndividuals.Q(
                Q_res.ToImmutableList());

            // R
            this.R = new C19M.M.C.A.Gumel2004.Classes.Results.DayRecoveredIndividuals.R(
                R_res.ToImmutableList());

            // S

            // DayDiseaseInducedDeaths
            this.DayDiseaseInducedDeaths = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_Calculation().Calculate(
                t,
                d_1,
                d_2,
                this.I,
                this.J);

            return this.DayDiseaseInducedDeaths.Value.Select(w => w.Value).Sum();
        }

        // https://stackoverflow.com/a/55004295
        private Func<double, MathNet.Numerics.LinearAlgebra.Vector<double>, MathNet.Numerics.LinearAlgebra.Vector<double>> f(
            It t,
            Interfaces.Parameters.DiseaseInducedDeathRateSymptomaticIndividuals.Id d_1,
            Interfaces.Parameters.DiseaseInducedDeathRateIsolatedIndividuals.Id d_2,
            Ip p,
            Iβ β,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.QuarantineRateAsymptomaticIndividuals.Iγ γ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.IsolationRateSymptomaticIndividuals.Iγ γ_2,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorAsymptomaticIndividuals.Iε ε_E,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorIsolatedIndividuals.Iε ε_J,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.TransmissionCoefficientModificationFactorQuarantinedIndividuals.Iε ε_Q,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals.Iκ κ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.DevelopmentClinicalSymptomsRateQuarantinedIndividuals.Iκ κ_2,
            Iμ μ,
            IΠ Π,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateSymptomaticIndividuals.Iσ σ_1,
            C19M.M.C.A.Gumel2004.Interfaces.Parameters.RecoveryRateIsolatedIndividuals.Iσ σ_2,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.AsymptomaticIndividuals.IE E,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.SymptomaticIndividuals.II I,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.IsolatedIndividuals.IJ J,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.QuarantinedIndividuals.IQ Q,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.RecoveredIndividuals.IR R,
            C19M.M.C.A.Gumel2004.Interfaces.Variables.SusceptibleIndividuals.IS S)
        {
            return (T, x) =>
            {
                return MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                    E.GetdEdt(
                        t.StartDate.AddDays(T),
                        p,
                        β,
                        γ_1,
                        γ_2,
                        ε_E,
                        ε_J,
                        ε_Q,
                        κ_1,
                        μ,
                        E: x[0],
                        I: x[1],
                        J: x[2],
                        N: x.Sum(),
                        Q: x[3],
                        S: x[5]),
                    I.GetdIdt(
                        t.StartDate.AddDays(T),
                        d_1,
                        γ_2,
                        κ_1,
                        μ,
                        σ_1,
                        E: x[0],
                        I: x[1]),
                    J.GetdJdt(
                        t.StartDate.AddDays(T),
                        d_2,
                        γ_2,
                        κ_2,
                        μ,
                        σ_2,
                        I: x[1],
                        J: x[2],
                        Q: x[3]),
                    Q.GetdQdt(
                        t.StartDate.AddDays(T),
                        γ_1,
                        κ_2,
                        μ,
                        E: x[0],
                        Q: x[3]),
                    R.GetdRdt(
                        μ,
                        σ_1,
                        σ_2,
                        I: x[1],
                        J: x[2],
                        R: x[4]),
                    S.GetdSdt(
                        t.StartDate.AddDays(T),
                        β,
                        ε_E,
                        ε_J,
                        ε_Q,
                        μ,
                        Π,
                        E: x[0],
                        I: x[1],
                        J: x[2],
                        N: x.Sum(),
                        Q: x[3],
                        S: x[5])
                });
            };
        }
    }
}