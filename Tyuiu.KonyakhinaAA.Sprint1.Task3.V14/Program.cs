using System;

using Tyuiu.KonyakhinaAA.Sprint1.Task3.V14.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

//ЗАДАНИЕ (Вариант 14)
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Написать программу, которая позволяет определить число, полученное выписыванием в обратном порядке
//цифр заданного трехзначного числа. Ответ округлите до 3 знаков после запятой.

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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Коняхина Анастасия Александровна | НТм-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая позволяет определить число,                 *");
            Console.WriteLine("* полученное выписыванием в обратном порядке заданного                    *");
            Console.WriteLine("* трехзначного числа. Ответ округлите до 3 знаков после запятой.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v;
            Console.WriteLine("Введите значение V: ");
            v = Convert.ToDouble(Console.ReadLine());

            if (v < 100.0 || v > 999.0)
            {
                Console.WriteLine("Ошибка: введено не трехзначное число");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine($"Перевернутое число: {ds.ReverseNumber(v):F3}");
            Console.ReadLine();
        }
    }
}