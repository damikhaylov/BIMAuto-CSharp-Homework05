using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Сформировать одномерный массив из 7 элементов. Заполнить массив числами,
            вводимыми с клавиатуры, определить среднее арифметическое элементов.
            */

            const int arrLength = 7;
            double[] array = new double[arrLength];
            double arrSum = 0;

            Console.WriteLine("Определение среднего арифметического из 7 элементов массива");
            Console.WriteLine();

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Введите число - значение элемента массива [{0}]: ", i);
                array[i] = Convert.ToDouble(Console.ReadLine());
                arrSum += array[i];
            }

            Console.WriteLine("Среднее арифметическое элементов массива равно {0}",
                              arrSum / arrLength);
            Console.ReadKey();
        }
    }
}
