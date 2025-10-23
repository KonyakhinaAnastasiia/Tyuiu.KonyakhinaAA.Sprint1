using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            int hundreds = (int)(number / 100);
            int tens = (int)(number / 10) % 10;
            int units = (int)number % 10;

            int reversedNumber = units * 100 + tens * 10 + hundreds;
            double result = reversedNumber;
            return result;
        }
    }
}
