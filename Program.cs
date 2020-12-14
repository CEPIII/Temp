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

            //Заодно найду максимальный элемент, минимальный и сумму всех элементов
            int min = arr[0, 0];
            int max = arr[0, 0];
            int summ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summ += arr[i, j];      //Подсчет Суммы элементов

                    if (min > arr[i, j]) min = arr[i, j];
                    if (max < arr[i, j]) max = arr[i, j];
                }
            }

            Console.WriteLine($"Наименьший элемент массива \n\tmin = {min}\n");
            Console.WriteLine($"Наибольший элемент массива \n\tmax = {max}\n");
            Console.WriteLine($"Сумма элементов массива \n\tsumm = {summ}\n");

            //Узнаю общее количество элементов двумерного массива
            int lengthArr = arr.Length;
            Console.WriteLine("Количество элементов двумерного массива = " + lengthArr);
            //Создаю одномерный универсальный массив принимающий значения вышеполученного многомерного 
            int[] arrFromTwin = new int[lengthArr];
            //Заполняю
            /*
            int x = 0;
            foreach (var item in arr)
            {

            }*/
        }
    }
}

