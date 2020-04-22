namespace C19M.M.C.A.Gumel2006.Classes.Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    internal sealed class RescaledDiseaseTransmission_Solution : IRescaledDiseaseTransmission_Solution
    {
        private ILog Log { get; }

        // Constructor
        public RescaledDiseaseTransmission_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}