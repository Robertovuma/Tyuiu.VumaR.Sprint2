using Tyuiu.VumaR.Sprint2.Task7.V2.Lib;
namespace Tyuiu.VumaR.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
