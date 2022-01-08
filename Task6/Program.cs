using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Запросить у пользователя целочисленное значение N. Сформировать двумерный массив 
            размера NxN. Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли 
            введенная с клавиатуры матрица магическим квадратом. Магическим квадратом называется 
            матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой 
            диагонали одинакова.
            */

            Console.WriteLine("Запрос значений массива NxN и проверка, "
                              + "является ли заданная матрица магическим квадратом");
            Console.WriteLine();

            Console.Write("Введите размерность массива N: ");
            uint arrSize = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();

            // Массив будет состоять из логических нулей и единиц
            double[,] array = new double[arrSize, arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine("Последовательно введите элементы строки матрицы {0}:", i + 1);
                for (int j = 0; j < arrSize; j++)
                {
                    array[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            double presumptiveMagicScuareSum = 0;
            double currentDirectionSum = 0;

            // Предположительное значение магического квадрата формируем суммой по диагонали
            for (int i = 0; i < arrSize; i++)
            {
                presumptiveMagicScuareSum += array[i, i];
            }

            // Проверяем сумму по второй диагонали
            for (int i = 0; i < arrSize; i++)
            {
                currentDirectionSum += array[i, arrSize - 1 - i];
            }
            bool maybeMagicScuare = (currentDirectionSum == presumptiveMagicScuareSum) ? true: false;

            // Если ещё есть надежда, проверяем суммы по каждой из строк
            for (int i = 0; i < arrSize && maybeMagicScuare; i++)
            {
                currentDirectionSum = 0;
                for (int j = 0; j < arrSize; j++)
                {
                    currentDirectionSum += array[i, j];
                }
                maybeMagicScuare = (currentDirectionSum == presumptiveMagicScuareSum) ? true : false;
            }

            // Если ещё есть надежда, проверяем суммы по каждому из столбцов
            for (int j = 0; j < arrSize && maybeMagicScuare; j++)
            {
                currentDirectionSum = 0;
                for (int i = 0; i < arrSize; i++)
                {
                    currentDirectionSum += array[i, j];
                }
                maybeMagicScuare = (currentDirectionSum == presumptiveMagicScuareSum) ? true : false;
            }

            if (maybeMagicScuare)
            {
                Console.WriteLine("Матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Матрица не является магическим квадратом");
            }

            Console.ReadKey();
        }
    }
}
