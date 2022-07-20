// Задача 58: Задайте две матрицы. Напишите программу, которая выведет 
//            матрицу произведения элементов двух предыдущих матриц.

//             Например, заданы 2 массива:

//             1 4 7 2 и 1 5 8 5
//             5 9 2 3   4 9 4 2
//             8 4 2 4   7 2 2 6
//             5 2 6 7   2 3 4 7

//             Их произведение будет равно следующему массиву:

//             1 20 56 10
//             20 81 8 6
//             56 8 4 24
//             10 6 24 49
namespace GeekBrains
{
    public static class HomeWork
    {
        public static void Main (string[] args)
        {
            Console.Clear();
            Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
            int m = InputNumbers("Введите число строк 1-й матрицы: ");
            int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
            int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
            int count = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

            int[,] firstMartrix = new int[m, n];
            FillArray(firstMartrix, count);
            Console.WriteLine($"Первая матрица:");
            PrintArray(firstMartrix);

            int[,] secondMartrix = new int[n, p];
            FillArray(secondMartrix, count);
            Console.WriteLine($"Вторая матрица:");
            PrintArray(secondMartrix);

            int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];

            MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
            Console.WriteLine($"Произведение первой и второй матриц:");
            PrintArray(resultMatrix);
        }
        
        public static void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
        {
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = firstMartrix[i, j] * secondMartrix[i, j];
                }
            }
        }

        public static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        public static void FillArray(int[,] array, int count)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                array[i, j] = new Random().Next(count);
                }
            }
        }
        public static void PrintArray (int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
        }
        }

    }
}