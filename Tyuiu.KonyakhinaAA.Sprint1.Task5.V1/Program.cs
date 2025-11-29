using System;

using Tyuiu.KonyakhinaAA.Sprint1.Task5.V1.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

//ЗАДАНИЕ (Вариант 1)
//Найти расстояние между двумя точками с заданными координатами (x, y).
//Ответ привести к целому с помощью класса Convert.

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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Коняхина Анастасия Александровна | НТм-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, y1, x2, y2;
            Console.WriteLine("Введите значение X1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Расчет по формуле: " + ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadLine();
        }
    }
}