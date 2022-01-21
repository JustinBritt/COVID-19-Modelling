namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayRecoveredIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayRecoveredIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayRecoveredIndividuals;

    internal sealed class R_ResultElement_Calculation : IR_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public R_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IR_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Safi2010.Classes.ResultElements.DayRecoveredIndividuals.R_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    (decimal)RungeKuttaResults[t.NumberDaysAfterStartDate.Invoke(t_IndexElement).Value.Value][4]));
        }
    }
}