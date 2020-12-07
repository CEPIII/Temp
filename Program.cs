using System;
using System.Collections;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительный диапазон значений случайных чисел, которые заполнят массив от 0 \n \tdiapazon = ");
            int diapazon = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nОпределите первый размер двумерного массива : \n\t[x, ] = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nОпределите второй размер двумерного массива : \n\t[, y] = ");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[x, y];
            //Заполнить массив рандомными значениями по заданному ранее диапазону
            Random rnd = new Random();
            //Заодно найду максимальный элемент, минимальный и сумму всех элементов
            int min, max;
            Console.WriteLine($"\nЗаполненный массив \n\t int[,] arr = new int[{x}, {y}]\n\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, diapazon);
                    Console.Write($"  {arr[i, j]}  ");
                }
                Console.WriteLine("}\n");
            }
        }
    }
}

