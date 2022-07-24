// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
namespace Geekbrains
{
    public class HomeWork 
    {   

        public static void Main(string[] args) 
        {
            Console.Clear();
            int n = InputNumbers("Введите число n = ");
            int m = InputNumbers("Введите число m = ");
            int res = Akkerman(n, m);
            Console.WriteLine("Результат:");
            Console.WriteLine(res);
        }
         public static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
    

        static int Akkerman(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
                if ((n != 0) && (m == 0))
                return Akkerman(n - 1, 1);
                else
                return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
}