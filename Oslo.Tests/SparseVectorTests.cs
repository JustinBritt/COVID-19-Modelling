using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Research.Oslo;

namespace Oslo.Tests
{
    [TestClass]
    public class SparseVectorTests
    {
        const double Eps = 1e-10;

        [TestMethod]
        public void ElementAccessorTest()
        {
            SparseVector sv = new SparseVector(1000);
            for (var i = 0; i < sv.Length / 2; i++)
            {
                sv[i] = i * i;
                sv[sv.Length - i - 1] = sv.Length - i - 1;
                for (var j = 0; j <= i; j++)
                {
                    Assert.AreEqual(sv[i], i * i, Eps);
                    Assert.AreEqual(sv[sv.Length - i - 1], sv.Length - i - 1);
                }
            }
        }
    }
}