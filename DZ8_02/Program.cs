namespace GeekBrains
{
    public class HomeWork
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine($"\nВведите размер массива M x N и диапазон случайных значений:");
            int m = InputNumbers("Введите M: ");
            int n = InputNumbers("Введите N: ");
            int count = InputNumbers("Введите диапазон: от 1 до ");

            int[,] array = new int[m, n];
            FillArray(array, count);
            PrintArray(array);

            int minSumLine = 0;
            int sumLine = SumLineElements(array, 0);
            for (int i = 1; i < array.GetLength(0); i++)
            {
                int tempSumLine = SumLineElements(array, i);
                if (sumLine > tempSumLine)
                {
                    sumLine = tempSumLine;
                    minSumLine = i;
                }
            }

            Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой = {sumLine} элементов ");
        }   

        public static int SumLineElements(int[,] array, int i)
        {
            int sumLine = array[i,0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                sumLine += array[i,j];
            }
            return sumLine;
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