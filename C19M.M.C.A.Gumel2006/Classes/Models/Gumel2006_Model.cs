namespace C19M.M.C.A.Gumel2006.Classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Contexts;

    using C19M.M.C.A.Gumel2006.Interfaces.Models;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.InfectedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.LatentIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.SusceptibleIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals;
    using C19M.M.C.A.Gumel2006.Interfaces.Variables.VaccinatedIndividuals;

    internal sealed class Gumel2006_Model : IGumel2006_Model
    {
        private ILog Log { get; }

        // Constructor
        public Gumel2006_Model(
            IGumel2006_Context context)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Parameters

            // Variables
        }
    }
}