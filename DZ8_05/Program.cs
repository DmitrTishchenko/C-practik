﻿// Задача 62. Заполните спирально массив 4 на 4.

namespace Geekbrains
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число N в квадратной матрице");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] sqareMatrix = new int[n, n];

            int temp = 1;
            int i = 0;
            int j = 0;

            while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
            {
            sqareMatrix[i, j] = temp;
            temp++;
            if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
                j--;
            else
                i--;
            }
        
        
            PrintArray(sqareMatrix);
        }
        static void PrintArray (int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                
                Console.Write($" {array[i,j]} ");

                
                }
                Console.WriteLine();
            }
        }
        
    }
}