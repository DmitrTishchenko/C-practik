// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//            значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

namespace GeekBrains
{
    public static class HomeWork
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите b1: ");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k1: ");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b2: ");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k2: ");
            double k2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Условие: y = k1 * x + b1, y = k2 * x + b2;");
            Console.Write($"где b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}.");
            Console.WriteLine();
            Console.WriteLine();

            Intersection(b1, k1, b2, k2);
            Console.WriteLine();

        }

        public static void Intersection( double b1, double k1, double b2, double k2)
        {
            if(k1 != k2)
            {
                double x = (b1-b2)/(k2-k1);
                double y = (k2*b1-k1*b2)/(k2-k1);
                Console.WriteLine($"Пересечение двух прямых = ({x}, {y})");
            }
            else
            {
                Console.WriteLine("Прямые параллельны");
            }
        }
    }
}