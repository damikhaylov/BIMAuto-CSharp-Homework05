using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
            Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            */

            const int arrLength = 10;
            const int minLimit = -50;
            const int maxLimit = 50;

            int[] array = new int[arrLength];

            Console.WriteLine("Сортировка массива: первой половины - по возрастанию,"
                              + "второй - по убыванию");
            Console.WriteLine();

            Console.Write("Элементы массива: ");
            Random rnd = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = rnd.Next(minLimit, maxLimit + 1);
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arrLength/2 - 1; i++)
            {
                for (int j = i+1; j < arrLength / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }

                }
            }

            for (int i = arrLength / 2; i < arrLength - 1; i++)
            {
                for (int j = i + 1; j < arrLength ; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }

                }
            }

            Console.Write("Отсортированные элементы массива: ");
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write(" {0}", array[i]);
            }

            Console.ReadKey();
        }
    }
}
