
using Tyuiu.VumaR.Sprint2.Task3.V17.Lib;

namespace Tyuiu.VumaR.Sprint2.Task3.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            var wait = 6565;
            Assert.AreEqual(wait, res);
        }
    }
}
