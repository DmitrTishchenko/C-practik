// Задача 64: Задайте значения M и N. 
//            Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
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
            
            Console.WriteLine($"M = {M}, N = {N}");
            if (M>N)
            for (int i = N; i <= M; i++)
                Console.Write($" {i}");
            else
                for (int i = M; i <= N; i++)
                    Console.Write($" {i}");

        }

        public static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

       
    }
}