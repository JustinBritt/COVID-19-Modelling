namespace C19M.M.C.A.Gumel2006.Classes.Results.DayCumulativeDiseaseInducedDeaths
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Hl7.Fhir.Model;

    using C19M.M.C.A.Gumel2006.Interfaces.ResultElements.DayCumulativeDiseaseInducedDeaths;

    using C19M.M.C.A.Gumel2006.Interfaces.Results.DayCumulativeDiseaseInducedDeaths;

    internal sealed class DayCumulativeDiseaseInducedDeaths : IDayCumulativeDiseaseInducedDeaths
    {
        private ILog Log { get; }

        public DayCumulativeDiseaseInducedDeaths(
            ImmutableList<IDayCumulativeDiseaseInducedDeaths_ResultElement> value)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.Value = value;
        }

        public ImmutableList<IDayCumulativeDiseaseInducedDeaths_ResultElement> Value { get; }
    }
}