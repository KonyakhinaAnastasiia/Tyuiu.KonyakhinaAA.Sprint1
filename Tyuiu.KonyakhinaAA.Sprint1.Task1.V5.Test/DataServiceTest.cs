using Tyuiu.KonyakhinaAA.Sprint1.Task1.V5.Lib;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6, res);
        }
    }
}
