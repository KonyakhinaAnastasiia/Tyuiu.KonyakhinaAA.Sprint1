using System;

using Tyuiu.KonyakhinaAA.Sprint1.Task6.V13.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

//ЗАДАНИЕ (Вариант 13)
//Написать программу: пользователь вводит текст.
//Проверить, что буквы строки упорядочены по алфавиту.

namespace Tyuiu.KonyakhinaAA.Sprint1.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Коняхина А.А. | НТм-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Коняхина Анастасия Александровна | НТм-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что буквы строки упорядочены по алфавиту.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value;
            Console.WriteLine("Введите строку: ");
            value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            bool isAlphabetical = ds.CheckWordsAlphabet(value);
            Console.WriteLine($"Буквы в строке {(isAlphabetical ? "упорядочены" : "НЕ упорядочены")} по алфавиту.");
            Console.ReadLine();
        }
    }
}