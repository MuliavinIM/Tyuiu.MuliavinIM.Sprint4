using Tyuiu.MuliavinIM.Sprint4.Task0.V29.Lib;
namespace Tyuiu.MuliavinIM.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] nums = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            int res = ds.GetSumOddArrEl(nums);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}