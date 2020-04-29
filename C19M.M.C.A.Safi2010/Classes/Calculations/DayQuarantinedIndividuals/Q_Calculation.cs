namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayQuarantinedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayQuarantinedIndividuals;

    internal sealed class Q_Calculation : IQ_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public Q_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IQ Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Safi2010.Classes.Results.DayQuarantinedIndividuals.Q(
                t.Value.Select(
                    w => new C19M.M.C.A.Safi2010.Classes.Calculations.DayQuarantinedIndividuals.Q_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}