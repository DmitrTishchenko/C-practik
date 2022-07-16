// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//            в двумерном массиве, и возвращает значение этого элемента или же
//            указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

namespace GeekBrains
{
    public static class HomeWork
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите искомое число: ");
            int search1 = Convert.ToInt32(Console.ReadLine());
            int rows = new Random().Next(2,10);
            int columns = new Random().Next(2,10);
            int[,] array = new int[rows,columns];
            FillArray(array);
            Console.WriteLine("Рандомный массив: ");
            PrintArray(array);
            SearchNumber(array, search1);

        }

        public static int[,] FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1,10);
                }
            }
            return array;
        }

        public static int[,] PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
            return array;
        }

        public static void SearchNumber (int[,] array, int search1)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == search1)
                    {
                        sum = sum + 1;
                    }
                }
            }
            if (sum == 0)
            {
                Console.WriteLine(search1+" -> такого числа в массиве нет");
            }
            else
            {
                Console.WriteLine($"{search1} -> данное число повторятся {sum} раз");
            }

        }
    }
} 