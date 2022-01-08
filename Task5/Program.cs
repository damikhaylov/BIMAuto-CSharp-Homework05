using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Запросить у пользователя целочисленное значение N. Сформировать двумерный массив
            размера NxN следующего вида:
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            */

            Console.WriteLine("Формирование массива NxN из чередующихся нулей и единиц");
            Console.WriteLine();

            Console.Write("Введите размерность массива N: ");
            uint arrSize = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();

            // Массив будет состоять из логических нулей и единиц
            bool[,] array = new bool[arrSize, arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                /* Первый элемент в массиве — логическая единица, первый элемент в каждой
                следующей строке противоположен первому элементу в предыдущей строке. */
                array[i, 0] = (i == 0) ? true : !array[i - 1, 0];
                Console.Write(Convert.ToByte(array[i, 0]));
                
                for (int j = 1; j < arrSize; j++)
                {
                    // Каждый элемент в строке, начиная со второго, противоположен предыдущему
                    array[i, j] = !array[i, j - 1];
                    Console.Write("{0,2}", Convert.ToByte(array[i, j]));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
