using Tyuiu.KonyakhinaAA.Sprint1.Task3.V14.Lib;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double value = 123.0;
            var res = ds.ReverseNumber(value);
            Assert.AreEqual(321.0, res);
        }
    }
}