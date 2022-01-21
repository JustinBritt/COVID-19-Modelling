namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayInfectedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayInfectedIndividuals;

    using C19M.M.C.A.Gumel2006.Interfaces.Indices;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayInfectedIndividuals;

    internal sealed class I_ResultElement_Calculation : II_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public I_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public II_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Gumel2006.Classes.ResultElements.DayInfectedIndividuals.I_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    (decimal)RungeKuttaResults[t.NumberDaysAfterStartDate.Invoke(t_IndexElement).Value.Value][1]));
        }
    }
}