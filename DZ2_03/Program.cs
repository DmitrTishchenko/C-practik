
namespace Geekbrains
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 15: Напишите программу, которая принимает на вход цифру,
            //            обозначающую день недели, и проверяет, является ли этот 
            //            день выходным.
            Console.Clear();
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: Console.WriteLine("Понедельник, рабочий день!"); break;
                case 2: Console.WriteLine("Вторник, более интенсивный рабочий день!"); break;
                case 3: Console.WriteLine("Среда, все еще работаем.."); break;
                case 4: Console.WriteLine("Четверг, РАБОЧИЙ"); break;
                case 5: Console.WriteLine("Пятница, полурабочий"); break;
                case 6: Console.WriteLine("Суббота, да! Выходной"); break;
                case 7: Console.WriteLine("Воскресенье, да! Выходной"); break;
                default: Console.WriteLine("ERROR"); break;
            }
            Console.ReadKey();

        }
    }

}
