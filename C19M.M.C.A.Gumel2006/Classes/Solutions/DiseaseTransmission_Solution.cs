﻿namespace C19M.M.C.A.Gumel2006.Classes.Solutions
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

    using C19M.M.C.A.Gumel2006.Interfaces.Solutions;

    internal sealed class DiseaseTransmission_Solution : IDiseaseTransmission_Solution
    {
        private ILog Log { get; }

        // Constructor
        public DiseaseTransmission_Solution()
        {
            this.Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        // TODO: Finish
        public MathNet.Numerics.LinearAlgebra.Vector<double>[] Solve()
        {
            throw new NotImplementedException();
        }

        // TODO: Finish
        private Func<double, MathNet.Numerics.LinearAlgebra.Vector<double>, MathNet.Numerics.LinearAlgebra.Vector<double>> f()
        {
            throw new NotImplementedException();
        }
    }
}