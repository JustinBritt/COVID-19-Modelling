namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayProbableCases
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

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayProbableCases;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.Results.DayHospitalizedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayInfectiousIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayProbableCases;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayQuarantinedIndividuals;
    using C19M.M.C.A.Safi2010.Interfaces.Results.DayRecoveredIndividuals;

    internal sealed class DayProbableCases_Calculation : IDayProbableCases_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayProbableCases Calculate(
            It t,
            IH H,
            II I,
            IQ Q,
            IR R)
        {
            return new C19M.M.C.A.Safi2010.Classes.Results.DayProbableCases.DayProbableCases(
                t.Value.Select(
                    w => new C19M.M.C.A.Safi2010.Classes.Calculations.DayProbableCases.DayProbableCases_ResultElement_Calculation().Calculate(
                        w,
                        H,
                        I,
                        Q,
                        R))
                .ToImmutableList());
        }
    }
}