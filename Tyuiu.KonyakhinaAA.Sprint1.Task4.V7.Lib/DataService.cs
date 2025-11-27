using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task4.V7.Lib
{
    public class DataService : ISprint1Task4V7
    {
        public double Calculate(double x, double y)
        {
            double res = (1 + Math.Sqrt(x * y)) / Math.Pow((x - 3 * y), 2);
            double finalRes = Math.Truncate(res * 1000) / 1000;
            return finalRes;
        }
    }
}