using Tyuiu.KonyakhinaAA.Sprint1.Task6.V13.Lib;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "acbdef";
            bool res = ds.CheckWordsAlphabet(value);
            Assert.AreEqual(false, res);
        }
    }
}
