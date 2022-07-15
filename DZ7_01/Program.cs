// Задача 47. Задайте двумерный массив размером m×n,
//            заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
namespace GeekBrains
{
    public static class HomeWork
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите число строк в массиве М = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число столбцов в массиве N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m,n];
            FillArray(array);
            PrintArray(array);
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

    }

}