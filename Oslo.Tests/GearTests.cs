using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Research.Oslo;

namespace Oslo.Tests
{
    [TestClass]
    public class GearTests
    {
        /// <summary>Solves dx/dt = exp(-x) equation with x(0) = 1 initial condition</summary>
        [TestMethod]
        public void ExponentSolveToGEarTest()
        {
            foreach (var sp in Ode.GearBDF(0,
                1,
                (t, x) => -x,
                new Options { RelativeTolerance = 1e-4 }).SolveTo(10))
                Assert.IsTrue(Math.Abs(sp.X[0] - Math.Exp(-sp.T)) < 1e-3);
        }

        /// <summary>Solves dx/dt = A*x equation with x(0) = {1,1} initial condition</summary>
        [TestMethod]
        public void JacobianGearTest()
        {
            var A = new Matrix(new double[,] { { -1, 0.5 }, { 0, -1 } });
            
            var sol = new List<double>();
            foreach (var sp in Ode.GearBDF(0,
                new Vector(1, 1),
                (t, x) => A * x).SolveFromToStep(0, 10, 0.1))
                sol.Add(sp.X[0]);
            
            var solJ = new List<double>();
            foreach (var sp in Ode.GearBDF(0,
                new Vector(1, 1),
                (t, x) => A * x).SolveFromToStep(0, 10, 0.1))
                solJ.Add(sp.X[0]);

            for (int i = 0; i < sol.Count; i++ )
                Assert.IsTrue(Math.Abs(sol[i] - solJ[i]) < 1e-3);
        }
    }
}
