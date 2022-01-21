namespace C19M.M.C.A.Gumel2006.Classes.Calculations.DayProbableCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.Calculations.DayProbableCases;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayProbableCases;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayInfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayLatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayTreatedIndividuals;

    internal sealed class DayProbableCases_ResultElement_Calculation : IDayProbableCases_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayProbableCases_ResultElement Calculate(
            FhirDateTime t_IndexElement,
            IE E,
            II I,
            IR R)
        {
            return new C19M.M.C.A.Gumel2006.Classes.ResultElements.DayProbableCases.DayProbableCases_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    E.GetElementAtAsdecimal(
                        t_IndexElement)
                    +
                    I.GetElementAtAsdecimal(
                        t_IndexElement)
                    +
                    R.GetElementAtAsdecimal(
                        t_IndexElement)));
        }
    }
}