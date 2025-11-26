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
            double x = 1.5;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.05549013944106031, res);
        }
    }
}
