    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
    //            по возрастанию элементы каждой строки двумерного массива.
    //            Например, задан массив:
    //            1 4 7 2
    //            5 9 2 3
    //            8 4 2 4
    //            В итоге получается вот такой массив:
    //            1 2 4 7
    //            2 3 5 9
    //            2 4 4 8
namespace GeekBrains
{
    public static class HomeWork
    {
        public static void Main (string[] args)
        {
            Console.Clear();
            Console.WriteLine($"Введите размер массива M x N и диапазон случайных значений:");
            int m = InputNumbers("Введите M: ");
            int n = InputNumbers("Введите N: ");
            int range = InputNumbers("Введите диапазон: от 1 до ");
            Console.WriteLine();

            int[,] array = new int[m, n];
            FillArray(array, range);
            PrintArray(array);
            Console.WriteLine();

            Console.WriteLine($"Отсортированный массив: ");
            Console.WriteLine();
            SortArray(array);
            PrintArray(array);
        }

        public static void SortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] > array[i, k + 1])
                    {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                    }
                }
                }
            }
        }

        public static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        public static void FillArray(int[,] array, int range)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                array[i, j] = new Random().Next(range);
                }
            }
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
