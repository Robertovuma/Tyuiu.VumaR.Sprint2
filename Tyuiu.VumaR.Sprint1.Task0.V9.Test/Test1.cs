
using Tyuiu.VumaR.Sprint1.Task0.V9.Lib;

namespace Tyuiu.VumaR.Sprint1.Task0.V9.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1054;
            int y = 375;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            bool[] wait = new bool[6] { true, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
