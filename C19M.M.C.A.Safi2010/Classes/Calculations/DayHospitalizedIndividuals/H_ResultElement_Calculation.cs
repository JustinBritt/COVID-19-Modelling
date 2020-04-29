namespace C19M.M.C.A.Safi2010.Classes.Calculations.DayHospitalizedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.Calculations.DayHospitalizedIndividuals;

    using C19M.M.C.A.Safi2010.Interfaces.Indices;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayHospitalizedIndividuals;

    internal sealed class H_ResultElement_Calculation : IH_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public H_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IH_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            It t,
            MathNet.Numerics.LinearAlgebra.Vector<double>[] RungeKuttaResults)
        {
            return new C19M.M.C.A.Safi2010.Classes.ResultElements.DayHospitalizedIndividuals.H_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    (decimal)RungeKuttaResults[t.NumberDaysAfterStartDate.Invoke(t_IndexElement).Value.Value][1]));
        }
    }
}