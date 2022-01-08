using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом
            из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.
            */

            const int arrLength = 15;
            const int minLimit = 0;
            const int maxLimit = 50;

            int[] array = new int[arrLength];
            int arrMin, arrMax;



            Console.WriteLine("Определение суммы максимального и минимального элемента "
                              + "в массиве, заполненном случайными значениями");
            Console.WriteLine();

            /* Операции заполнения массива и поиска минимума-максимума могут быть реализованы
            внутри одного цикла, но разнесены по двум циклам для упрощения кода */

            Console.Write("Элементы массива: ");
            Random rnd = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = rnd.Next(minLimit, maxLimit + 1);
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();

            arrMin = arrMax = array[0];

            for (int i = 1; i < arrLength; i++)
            {
                if (array[i] < arrMin)
                    arrMin = array[i];
                if (array[i] > arrMax)
                    arrMax = array[i];
            }

            Console.WriteLine();
            Console.WriteLine("Минимальный элемент массива: {0}, максимальный элемент: {1}",
                              arrMin, arrMax);
            Console.WriteLine("Сумма минимального и максимального элементов массива: {0}",
                              arrMin + arrMax);
            Console.ReadKey();
        }
    }
}
