using Tyuiu.MuliavinIM.Sprint4.Task7.V1.Lib;

namespace Tyuiu.MuliavinIM.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "135792468";
            int n = 3;
            int m = 3;

            int res = ds.Calculate(n, m, value);
            int wait = 4;     // Чётные цифры: 2, 4, 6, 8

            Assert.AreEqual(wait, res);
        }
    }
}
