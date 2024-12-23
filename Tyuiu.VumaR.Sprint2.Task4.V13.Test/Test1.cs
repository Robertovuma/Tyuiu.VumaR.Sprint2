
using Tyuiu.VumaR.Sprint2.Task4.V13.Lib;

namespace Tyuiu.VumaR.Sprint2.Task4.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void CheckCondition1()
        {
            double x = 25;
            double y = 20;
            Assert.AreEqual(1.555, new DataService().Calculate(x, y));
        }


        [TestMethod]
        public void CheckCondition2()
        {
            double x = 25;
            double y = 60;
            Assert.AreEqual(0.177, new DataService().Calculate(x, y));
        }
    }
}
