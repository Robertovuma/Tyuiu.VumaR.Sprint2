
using Tyuiu.VumaR.Sprint2.Task1.V22.Lib;

namespace Tyuiu.VumaR.Sprint2.Task1.V22.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            int a = 247, b = 654, c = 671, d = 671;
            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a, b, c, d));
        }
    }
}
