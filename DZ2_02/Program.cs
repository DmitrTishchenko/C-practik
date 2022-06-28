
namespace Geekbrains
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 13: Напишите программу, которая выводит третью цифру 
            //            заданного числа или сообщает, что третьей цифры нет.
            Console.Clear();
            Console.WriteLine("Введите число: ");
            string? str = Console.ReadLine();

            if (int.TryParse(str, out int val))
            {
                if (str.Length > 2)
                {
                    Console.WriteLine($"Третья цифра цисла {str} это {str[2]}");                         

                }
                else Console.WriteLine("Третьей цифры нет");
            }
            else Console.WriteLine("Неверный код");

        }
    }

}
