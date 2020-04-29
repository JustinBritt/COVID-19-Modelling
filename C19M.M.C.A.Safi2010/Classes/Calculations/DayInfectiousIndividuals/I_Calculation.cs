namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayInfectiousIndividuals
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

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayInfectiousIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayInfectiousIndividuals;

    internal sealed class I_Calculation : II_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public I_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public II Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Safi2010.Classes.Results.DayInfectiousIndividuals.I(
                t.Value.Select(
                    w => new C19M.M.C.A.Safi2010.Classes.Calculations.DayInfectiousIndividuals.I_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}