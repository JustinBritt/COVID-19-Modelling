namespace C19M.M.C.A.Gumel2004.Classes.Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2004.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2004.Interfaces.Indices;

    using C19M.M.C.A.Gumel2004.Interfaces.Models;

    using C19M.M.C.A.Gumel2004.Interfaces.Parameters.BasicTransmissionCoefficient;
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
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases;
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

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeDiseaseInducedDeaths.IDayCumulativeDiseaseInducedDeaths DayCumulativeDiseaseInducedDeaths { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayCumulativeProbableCases.IDayCumulativeProbableCases DayCumulativeProbableCases { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayDiseaseInducedDeaths.IDayDiseaseInducedDeaths DayDiseaseInducedDeaths { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayProbableCases.IDayProbableCases DayProbableCases { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayAsymptomaticIndividuals.IE E { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals.II I { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals.IJ J { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals.IQ Q { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals.IR R { get; private set; }

        public C19M.M.C.A.Gumel2004.Interfaces.Results.DaySusceptibleIndividuals.IS S { get; private set; }

        public void Solve(
            IGumel2004_Context Gumel2004_Context)
        {
            IGumel2004_Model Gumel2004_Model = new C19M.M.C.A.Gumel2004.Classes.Models.Gumel2004_Model(
                Gumel2004_Context);

            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults = 
                MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(
                    MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new[] {
                        (double)Gumel2004_Model.E.InitialValue.Value.Value,
                        (double)Gumel2004_Model.I.InitialValue.Value.Value,
                        (double)Gumel2004_Model.J.InitialValue.Value.Value,
                        (double)Gumel2004_Model.Q.InitialValue.Value.Value,
                        (double)Gumel2004_Model.R.InitialValue.Value.Value,
                        (double)Gumel2004_Model.S.InitialValue.Value.Value}),
                    Gumel2004_Model.t.NumberDaysAfterStartDate(Gumel2004_Model.t.StartDate).Value.Value,
                    Gumel2004_Model.t.NumberDaysAfterStartDate(Gumel2004_Model.t.EndDate).Value.Value,
                    Gumel2004_Model.t.NumberDaysAfterStartDate(Gumel2004_Model.t.EndDate).Value.Value - Gumel2004_Model.t.NumberDaysAfterStartDate(Gumel2004_Model.t.StartDate).Value.Value + 1,
                    this.f(
                        Gumel2004_Model.t,
                        Gumel2004_Model.d_1,
                        Gumel2004_Model.d_2,
                        Gumel2004_Model.p,
                        Gumel2004_Model.β,
                        Gumel2004_Model.γ_1,
                        Gumel2004_Model.γ_2,
                        Gumel2004_Model.ε_E,
                        Gumel2004_Model.ε_J,
                        Gumel2004_Model.ε_Q,
                        Gumel2004_Model.κ_1,
                        Gumel2004_Model.κ_2,
                        Gumel2004_Model.μ,
                        Gumel2004_Model.Π,
                        Gumel2004_Model.σ_1,
                        Gumel2004_Model.σ_2,
                        Gumel2004_Model.E,
                        Gumel2004_Model.I,
                        Gumel2004_Model.J,
                        Gumel2004_Model.Q,
                        Gumel2004_Model.R,
                        Gumel2004_Model.S));

            // E
            this.E = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayAsymptomaticIndividuals.E_Calculation().Calculate(
                Gumel2004_Model.t,
                RungeKuttaResults);

            // I
            this.I = new C19M.M.C.A.Gumel2004.Classes.Calculations.DaySymptomaticIndividuals.I_Calculation().Calculate(
                Gumel2004_Model.t,
                RungeKuttaResults);

            // J
            this.J = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayIsolatedIndividuals.J_Calculation().Calculate(
                Gumel2004_Model.t,
                RungeKuttaResults);

            // Q
            this.Q = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayQuarantinedIndividuals.Q_Calculation().Calculate(
                Gumel2004_Model.t,
                RungeKuttaResults);

            // R
            this.R = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayRecoveredIndividuals.R_Calculation().Calculate(
                Gumel2004_Model.t,
                RungeKuttaResults);

            // S
            this.S = new C19M.M.C.A.Gumel2004.Classes.Calculations.DaySusceptibleIndividuals.S_Calculation().Calculate(
                Gumel2004_Model.t,
                RungeKuttaResults);

            // DayDiseaseInducedDeaths
            this.DayDiseaseInducedDeaths = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayDiseaseInducedDeaths.DayDiseaseInducedDeaths_Calculation().Calculate(
                Gumel2004_Model.t,
                Gumel2004_Model.d_1,
                Gumel2004_Model.d_2,
                this.I,
                this.J);

            // DayProbableCases
            this.DayProbableCases = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayProbableCases.DayProbableCases_Calculation().Calculate(
                Gumel2004_Model.t,
                this.I,
                this.J,
                this.Q,
                this.R);

            // DayCumulativeDiseaseInducedDeaths
            this.DayCumulativeDiseaseInducedDeaths = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeDiseaseInducedDeaths.DayCumulativeDiseaseInducedDeaths_Calculation().Calculate(
                Gumel2004_Model.t,
                this.DayDiseaseInducedDeaths);

            // DayCumulativeProbableCases
            this.DayCumulativeProbableCases = new C19M.M.C.A.Gumel2004.Classes.Calculations.DayCumulativeProbableCases.DayCumulativeProbableCases_Calculation().Calculate(
                Gumel2004_Model.t,
                this.DayProbableCases);
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
                    (double)E.GetdEdt(
                        new FhirDateTime(
                            new DateTimeOffset(
                                t.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date.AddDays(T))),
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
                    (double)I.GetdIdt(
                        new FhirDateTime(
                            new DateTimeOffset(
                                t.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date.AddDays(T))),
                        d_1,
                        γ_2,
                        κ_1,
                        μ,
                        σ_1,
                        E: x[0],
                        I: x[1]),
                    (double)J.GetdJdt(
                        new FhirDateTime(
                            new DateTimeOffset(
                                t.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date.AddDays(T))),
                        d_2,
                        γ_2,
                        κ_2,
                        μ,
                        σ_2,
                        I: x[1],
                        J: x[2],
                        Q: x[3]),
                    (double)Q.GetdQdt(
                        new FhirDateTime(
                            new DateTimeOffset(
                                t.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date.AddDays(T))),
                        γ_1,
                        κ_2,
                        μ,
                        E: x[0],
                        Q: x[3]),
                    (double)R.GetdRdt(
                        μ,
                        σ_1,
                        σ_2,
                        I: x[1],
                        J: x[2],
                        R: x[4]),
                    (double)S.GetdSdt(
                        new FhirDateTime(
                            new DateTimeOffset(
                                t.StartDate.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date.AddDays(T))),
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