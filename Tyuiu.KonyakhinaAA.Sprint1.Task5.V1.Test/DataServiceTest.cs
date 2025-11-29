using Tyuiu.KonyakhinaAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 3.0;
            double y2 = 4.0;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(3, res);
        }
    }
}
