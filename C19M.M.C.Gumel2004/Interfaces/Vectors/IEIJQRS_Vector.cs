namespace C19M.M.C.Gumel2004.Interfaces.Vectors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IEIJQRS_Vector
    {
        double E { get; }

        double I { get; }

        double J { get; }

        double N { get; }

        double Q { get; }

        double R { get; }

        double S { get; }

        MathNet.Numerics.LinearAlgebra.Double.DenseVector Vector { get; }
    }
}