using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VyazovES.Sprint0.Task7.V0.Lib;

namespace Tyuiu.VyazovES.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Вязов Е. С. | НТм-24-1";


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #0                                                              *");
            Console.WriteLine("* Тема: Создание гoтового решения по спрнту                              *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #0                                                             *");
            Console.WriteLine("* Выполнил: Вязов Егор Сергеевич | НТм-24-1                              *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух   *");
            Console.WriteLine("* одинаковых массивов по длине.                                                             *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int[] arrayNum1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNum1.Length; i++)
            {
                Console.Write(arrayNum1[i] + ", ");
            }

            Console.WriteLine();



            int[] arrayNum2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNum1.Length; i++)
            {
                Console.Write(arrayNum1[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (arrayNum1.Length == arrayNum2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNum1, arrayNum2);
                Console.WriteLine("Сумма элементов массива равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количичетсво элементов!");
            }
            Console.ReadKey();
        
        
        }
    }
}
