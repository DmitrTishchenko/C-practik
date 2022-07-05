// Задача 27: Напишите программу, которая принимает 
//            на вход число и выдаёт сумму цифр в числе.

//             452 -> 11

//             82 -> 10

//             9012 -> 12
namespace Geekbrains
{
    public static class HomeWork
    {
        public static void Main()
        {
            Console.Clear();
            int number = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                else
                    Console.WriteLine("Неверное число.");
            }
            
            Sum(number);
           
            
        }
        public static void Sum(int number)
        {
            int oldValue = number;
            int sum = 0;
            while (number > 0)
            {
                int dig = number % 10;
                sum = sum + dig;
                number = number / 10;
            }
            
                Console.WriteLine($"Сумма цифр числа {oldValue} = {sum}");
        }
    }
}