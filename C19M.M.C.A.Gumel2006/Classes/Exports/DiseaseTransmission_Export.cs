namespace C19M.M.C.A.Gumel2006.Classes.Exports
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

    using C19M.M.C.A.Gumel2006.Interfaces.Exports;

    public sealed class DiseaseTransmission_Export : IDiseaseTransmission_Export
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseTransmission_Export()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}