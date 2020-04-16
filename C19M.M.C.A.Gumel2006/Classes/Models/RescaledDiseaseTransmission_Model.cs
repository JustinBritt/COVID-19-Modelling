namespace C19M.M.C.A.Gumel2006.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Models;

    internal sealed class RescaledDiseaseTransmission_Model : IRescaledDiseaseTransmission_Model
    {
        private ILog Log { get; }

        // Constructor
        public RescaledDiseaseTransmission_Model()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}