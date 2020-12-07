using System;
using System.Collections;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Подсчитать сумму двумерного массива
            /// Найти минимальный элемент массива
            /// </summary>

            int[,] arr = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int rank = arr.Rank;
            Console.WriteLine(rank);
        }
    }
}

