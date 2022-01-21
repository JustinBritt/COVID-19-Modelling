namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayTreatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayTreatedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Indices;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayTreatedIndividuals;

    internal sealed class R_ResultElement_Calculation : IR_ResultElement_Calculation
    {
        private ILog Log { get; }

        public R_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IR_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2006.Classes.ResultElements.DayTreatedIndividuals.R_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    (decimal)RungeKuttaResults[t.NumberDaysAfterStartDate.Invoke(t_IndexElement).Value.Value][2]));
        }
    }
}