namespace C19M.M.C.Gumel2004.Classes.Vectors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using C19M.M.C.Gumel2004.Interfaces.Vectors;

    internal sealed class EIJQRS_Vector : MathNet.Numerics.LinearAlgebra.Double.DenseVector, IEIJQRS_Vector 
    {
        public EIJQRS_Vector(
            double E,
            double I,
            double J,
            double Q,
            double R,
            double S) : base(6)
        {
            this[0] = E;

            this[1] = I;

            this[2] = J;

            this[3] = Q;

            this[4] = R;

            this[5] = S;
        }

        public double E => this[0];

        public double I => this[1];

        public double J => this[2];

        public double N => this.Sum();

        public double Q => this[3];

        public double R => this[4];

        public double S => this[5];

        public MathNet.Numerics.LinearAlgebra.Double.DenseVector Vector => this;
    }
}