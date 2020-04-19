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
        public MathNet.Numerics.LinearAlgebra.Vector<double>[] Solve()
        {
            throw new NotImplementedException();
        }

        // TODO: Finish
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
                    (double)N.GetdJdt(),
                    (double)R.GetdQdt(),
                    (double)S.GetdRdt(),
                    (double)V.GetdSdt()
                });
            };
        }
    }
}