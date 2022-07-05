// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//             и возводит число A в натуральную степень B.

//              3, 5 -> 243 (3⁵)

//              2, 4 -> 16
namespace Geekbrains 
{
    public static class HomeWork
    {
        public static void Main()
        {
            Console.WriteLine("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Я бы сделал так: 

            // double pow = Math.Pow(a,b);
            // Console.WriteLine($"{a}^{b} = {pow}");  

            // но в задании через цикл 

            
            Step(a,b);
            


        }
        public static void Step (int a, int b)
        {
            int i = 1;
            int res = a;
            while (i < b)
            {
                res = res * a ;
                i++;
            }
             Console.WriteLine(res);
        }

        
    }
}