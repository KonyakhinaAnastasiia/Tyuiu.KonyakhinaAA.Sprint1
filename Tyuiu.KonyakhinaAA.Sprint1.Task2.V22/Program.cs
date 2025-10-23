using System;

using Tyuiu.KonyakhinaAA.Sprint1.Task2.V22.Lib;

//ЗАДАНИЕ (Вариант 22)
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Формулировка задания: Заданы три числа. Вычислить среднее значение из них.
//Что пользователь вводит? Первое число (целое число), Второе число (целое число), Третье число (целое число)
//Что программа печатает на экране? Среднее значение (целое число)

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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Коняхина Анастасия Александровна | НТм-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Формулировка задания: Заданы три числа.                                 *");
            Console.WriteLine("* Вычислить среднее значение из них.                                      *");
            Console.WriteLine("* Пользователь вводит три целых числа.                                    *");
            Console.WriteLine("* Программа выводит среднее значение (целое число).                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b, c;
            Console.WriteLine("Введите значение A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение C: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine($"Среднее значение: {ds.CalculateAVGValue(a, b, c)}");
            Console.ReadLine();
        }
    }
}