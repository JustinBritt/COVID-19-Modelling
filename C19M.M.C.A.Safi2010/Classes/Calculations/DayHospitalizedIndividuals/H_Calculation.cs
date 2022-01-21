namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayHospitalizedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayHospitalizedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayHospitalizedIndividuals;

    internal sealed class H_Calculation : IH_Calculation
    {
        private ILog Log { get; }

        public H_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IH Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Safi2010.Classes.Results.DayHospitalizedIndividuals.H(
                t.Value.Select(
                    w => new C19M.M.C.A.Safi2010.Classes.Calculations.DayHospitalizedIndividuals.H_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}