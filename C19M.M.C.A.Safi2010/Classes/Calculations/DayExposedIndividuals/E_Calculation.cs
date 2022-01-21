namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayExposedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayExposedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayExposedIndividuals;

    internal sealed class E_Calculation : IE_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public E_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IE Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Safi2010.Classes.Results.DayExposedIndividuals.E(
                t.Value.Select(
                    w => new C19M.M.C.A.Safi2010.Classes.Calculations.DayExposedIndividuals.E_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}