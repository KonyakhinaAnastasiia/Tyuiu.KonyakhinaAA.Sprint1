using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task2.V22.Lib
{
    public class DataService : ISprint1Task2V22
    {
        public int CalculateAVGValue(int value, int valueTwo, int valueThree)
        {
            return (value + valueTwo + valueThree) / 3;
        }
    }
}
