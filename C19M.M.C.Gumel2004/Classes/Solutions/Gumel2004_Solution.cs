namespace C19M.M.C.Gumel2004.Classes.Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.Gumel2004.Interfaces.Solutions;

    internal sealed class Gumel2004_Solution : IGumel2004_Solution
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2004_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}