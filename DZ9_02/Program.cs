// Задача 66: Задайте значения M и N. Напишите программу,
//            которая найдёт сумму натуральных элементов в промежутке от M до N.
namespace GeekBrains
{
    class HomeWork
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите диапазон от M до N ");
            int M = InputNumbers("Введите число M = ");
            int N = InputNumbers("Введите число N = ");
            int sum = 0;
            
            Console.WriteLine($"M = {M}, N = {N}");
            if (M>N)
            for (int i = N+1; i < M; i++)
                sum = sum+i ;
            else
                for (int i = M+1; i < N; i++)
                    sum = sum+i;
            Console.WriteLine("Сумма заданного диапазона:");
            Console.Write(sum);

        }

        public static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

       
    }
}