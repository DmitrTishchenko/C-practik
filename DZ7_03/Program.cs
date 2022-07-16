// Задача 52.  Задайте двумерный массив из целых чисел. 
//             Найдите среднее арифметическое элементов в каждом столбце.

//             Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//             Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace GeekBrains
{
    public static class HomeWork
    {
        public static void Main(string[] args)
        {
            int rows = new Random().Next(2,8);
            int columns = new Random().Next(2,8);
            int [,] array = new int[rows, columns];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            ArithmeticAverage(array, columns);
        }

        public static int[,] FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(3,10);
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

        public static void ArithmeticAverage(int[,] array, int columns)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                double averge = 0;
                double averge2 = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    averge =(averge + array[i, j])/columns;
                    averge2= Math.Round(averge,2);

                }
                Console.Write(averge2+" ");
                
            }
           
            
        }
    }
}