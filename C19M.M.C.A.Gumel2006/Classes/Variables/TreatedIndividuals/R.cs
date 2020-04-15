namespace C19M.M.C.A.Gumel2006.Classes.Variables.TreatedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Logging
    using log4net;

    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.NaturalMortalityRate;
    using C19M.M.C.A.Gumel2006.Interfaces.Parameters.RecoveryRate;

    using C19M.M.C.A.Gumel2006.Interfaces.Variables.TreatedIndividuals;

    internal sealed class R : IR
    {
        private ILog Log { get; }

        // Constructor
        public R(
            double initialValue)
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            this.InitialValue = initialValue;
        }

        public double InitialValue { get; }

        public double GetdRdt(
            Iδ δ,
            Iμ μ,
            double I,
            double R)
        {
            return
                δ.Value * I
                -
                μ.Value * R;
        }
    }
}