using System;

using Tyuiu.KonyakhinaAA.Sprint1.Task1.V5.Lib;

//ЗАДАНИЕ (Вариант 5)
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле (5 + (x * y / 3)) и печатает его на экране.

namespace Tyuiu.KonyakhinaAA.Sprint1.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Коняхина А.А. | НТм-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Коняхина Анастасия Александровна | НТм-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (5 + (x * y / 3))       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (5 + (x * y / 3))                                                       *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}