using AlgorithmPackage.DivideAndConquer.MaximumSumOfChildArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivideAndConquerTest
{
    [TestClass]
    public class DivideAndConquerTest
    {
        [TestMethod]
        public void TestMaximumSumOfChildArray()
        {
            MaximumSumOfChildArray a = new MaximumSumOfChildArray(new Parameters() { InputArray = new int[] { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 } });
            Result r = a.GetSolution(null) as Result;
            Assert.AreEqual(r.Sum, 43);
            Assert.AreEqual(r.begin, 7);
            Assert.AreEqual(r.end, 10);

            MaximumSumOfChildArray b = new MaximumSumOfChildArray(new Parameters() { InputArray = new int[] { 13, -3, -25, 20, -3 } });
            Result r2 = b.GetSolution(null) as Result;
            Assert.AreEqual(r2.Sum, 20);
            Assert.AreEqual(r2.begin, 3);
            Assert.AreEqual(r2.end, 3);

            MaximumSumOfChildArray c = new MaximumSumOfChildArray(new Parameters() { InputArray = new int[] {-3} });
            Result r3 = c.GetSolution(null) as Result;
            Assert.AreEqual(r3.Sum, -3);
            Assert.AreEqual(r3.begin, 0);
            Assert.AreEqual(r3.end, 0);

            MaximumSumOfChildArray d = new MaximumSumOfChildArray(new Parameters() { InputArray = new int[] { -3, 5 } });
            Result r4 = d.GetSolution(null) as Result;
            Assert.AreEqual(r4.Sum, 5);
            Assert.AreEqual(r4.begin, 1);
            Assert.AreEqual(r4.end, 1);

            MaximumSumOfChildArray e = new MaximumSumOfChildArray(new Parameters() { InputArray = new int[] { -3, 5, 6 } });
            Result r5 = e.GetSolution(null) as Result;
            Assert.AreEqual(r5.Sum, 11);
            Assert.AreEqual(r5.begin, 1);
            Assert.AreEqual(r5.end, 2);
        }
    }
}
