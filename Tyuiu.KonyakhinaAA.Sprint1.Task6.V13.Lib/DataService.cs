using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KonyakhinaAA.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            var letters = value.Where(char.IsLetter)
                               .Select(char.ToLower)
                               .ToArray();

            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i] < letters[i - 1])
                    return false;
            }

            return true;
        }
    }
}
