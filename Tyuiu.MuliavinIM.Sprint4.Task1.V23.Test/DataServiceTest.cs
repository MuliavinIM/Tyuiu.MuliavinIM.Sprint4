using Tyuiu.MuliavinIM.Sprint4.Task1.V23.Lib;
namespace Tyuiu.MuliavinIM.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 5, 9, 6, 4, 5 };
            int res = ds.Calculate(array);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}