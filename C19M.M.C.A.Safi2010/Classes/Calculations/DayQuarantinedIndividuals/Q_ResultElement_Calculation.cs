namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayQuarantinedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayQuarantinedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayQuarantinedIndividuals;

    internal sealed class Q_ResultElement_Calculation : IQ_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public Q_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IQ_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Safi2010.Classes.ResultElements.DayQuarantinedIndividuals.Q_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    (decimal)RungeKuttaResults[t.NumberDaysAfterStartDate.Invoke(t_IndexElement).Value.Value][3]));
        }
    }
}