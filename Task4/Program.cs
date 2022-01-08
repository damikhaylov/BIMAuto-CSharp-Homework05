using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
            Определить количество нечетных положительных элементов, стоящих на четных местах.
            */

            const int arrLength = 20;
            const int minLimit = -50;
            const int maxLimit = 50;
            int[] array = new int[arrLength];
            int countOddPosWithEvenIndex = 0;

            Console.WriteLine("Определение количиства нечётных положительных элементов массива,"
                              + "стоящих на чётных местах");
            Console.WriteLine();

            Console.Write("Элементы массива: ");
            Random rnd = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = rnd.Next(minLimit, maxLimit + 1);
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();

            Console.Write("Элементы массива на чётных местах: ");
            for (int i = 1; i < arrLength; i += 2)
            {
                if (array[i] > 0 && (array[i] % 2) == 1)
                {
                    countOddPosWithEvenIndex++;
                    Console.Write(" <{0}>", array[i]);
                }
                else
                    Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Количиство нечётных положительных элементов массива,"
                              + "стоящих на чётных местах: {0}", countOddPosWithEvenIndex);

            Console.ReadKey();
        }
    }
}
