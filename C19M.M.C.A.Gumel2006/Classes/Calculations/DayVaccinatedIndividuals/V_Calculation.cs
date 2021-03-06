﻿namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayVaccinatedIndividuals
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

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayVaccinatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Indices;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayVaccinatedIndividuals;

    internal sealed class V_Calculation : IV_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public V_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IV Calculate(
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2006.Classes.Results.DayVaccinatedIndividuals.V(
                t.Value.Select(
                    w => new C19M.M.C.A.Gumel2006.Classes.Calculations.DayVaccinatedIndividuals.V_ResultElement_Calculation().Calculate(
                        w,
                        t,
                        RungeKuttaResults))
                .ToImmutableList());
        }
    }
}