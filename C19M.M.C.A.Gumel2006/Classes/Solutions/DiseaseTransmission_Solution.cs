﻿namespace C19M.M.C.A.Gumel2006.Classes.Solutions
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

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    internal sealed class DiseaseTransmission_Solution : IDiseaseTransmission_Solution
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseTransmission_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public MathNet.Numerics.LinearAlgebra.Vector<double>[] Solve(
            IGumel2006_Context Gumel2006_Context)
        {
            IDiseaseTransmission_Model diseaseTransmission_Model = new C19M.M.C.A.Gumel2006.Classes.Models.DiseaseTransmission_Model(
                Gumel2006_Context);

            MathNet.Numerics.LinearAlgebra.Vector<double>[] results =
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
            C19M.M.C.A.Gumel2006.Interfaces.Variables.TotalPopulationSize.IN N,
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
                        S: x[4],
                        V: x[5]),
                    (double)I.GetdIdt(
                        d,
                        α,
                        δ,
                        μ,
                        E: x[0],
                        I: x[1]),
                    (double)N.GetdNdt(
                        d,
                        μ,
                        Π,
                        I: x[1],
                        N: x[2]),
                    (double)R.GetdRdt(
                        δ,
                        μ,
                        I: x[1],
                        R: x[3]),
                    (double)S.GetdSdt(
                        β,
                        μ,
                        ξ,
                        Π,
                        I: x[1],
                        S: x[4]),
                    (double)V.GetdVdt(
                        β,
                        μ,
                        ξ,
                        τ,
                        I: x[1],
                        S: x[4],
                        V: x[5])
                });
            };
        }
    }
}