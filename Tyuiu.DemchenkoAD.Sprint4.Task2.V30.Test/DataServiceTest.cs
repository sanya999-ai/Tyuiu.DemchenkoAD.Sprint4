using Tyuiu.DemchenkoAD.Sprint4.Task2.V30.Lib;
namespace Tyuiu.DemchenkoAD.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] Numsarray = { 7, 5, 8, 3, 4, 5, 2, 4, 7, 3, 8, 5 };
            int wait = 55125;
            int res = ds.Calculate(Numsarray);

            Assert.AreEqual(wait, res);
        }
    }
}