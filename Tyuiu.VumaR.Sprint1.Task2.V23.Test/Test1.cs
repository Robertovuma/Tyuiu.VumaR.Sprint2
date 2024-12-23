
using Tyuiu.VumaR.Sprint1.Task2.V23.Lib;

namespace Tyuiu.VumaR.Sprint1.Task2.V23.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
