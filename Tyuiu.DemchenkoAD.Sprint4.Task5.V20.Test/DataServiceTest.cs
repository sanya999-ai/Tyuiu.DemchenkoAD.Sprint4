using Tyuiu.DemchenkoAD.Sprint4.Task5.V20.Lib;
namespace Tyuiu.DemchenkoAD.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5]{ { 1, 2, -3, -8, 0 },

                                          { 0, -7, 0, 0, 0 },

                                          { 0, 2, 0, 1, 1 },

                                          { 1, -4, 0, 3, -5 },

                                          { 0, 2, 0, 1, 0 } };

            int res = ds.Calculate(array);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}