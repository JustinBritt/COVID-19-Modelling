namespace C19M.M.C.A.Gumel2004.Classes.Calculations.DayProbableCases
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

    using C19M.M.C.A.Gumel2004.Interfaces.Calculations.DayProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.ResultElements.DayProbableCases;

    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayIsolatedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayQuarantinedIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DayRecoveredIndividuals;
    using C19M.M.C.A.Gumel2004.Interfaces.Results.DaySymptomaticIndividuals;

    internal sealed class DayProbableCases_ResultElement_Calculation : IDayProbableCases_ResultElement_Calculation
    {
        private ILog Log { get; }

        // Constructor
        public DayProbableCases_ResultElement_Calculation()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public IDayProbableCases_ResultElement Calculate(
            DateTime t_IndexElement,
            II I,
            IJ J,
            IQ Q,
            IR R)
        {
            return new C19M.M.C.A.Gumel2004.Classes.ResultElements.DayProbableCases.DayProbableCases_ResultElement(
                t_IndexElement,
                new FhirDecimal(
                    I.GetElementAtAsdecimal(
                        t_IndexElement)
                    +
                    J.GetElementAtAsdecimal(
                        t_IndexElement)
                    +
                    Q.GetElementAtAsdecimal(
                        t_IndexElement)
                    +
                    R.GetElementAtAsdecimal(
                        t_IndexElement)));
        }
    }
}