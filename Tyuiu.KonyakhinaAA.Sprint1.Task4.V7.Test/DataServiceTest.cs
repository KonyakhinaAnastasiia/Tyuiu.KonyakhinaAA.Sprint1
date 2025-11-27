using Tyuiu.KonyakhinaAA.Sprint1.Task4.V7.Lib;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.187, res);
        }
    }
}
