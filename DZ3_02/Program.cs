// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
//            и находит расстояние между ними в 3D пространстве.
namespace Geekbrains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки xA: ");
            double xA = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите координаты точки yA: ");
            double yA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки zA: ");
            double zA = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Введите координаты точки xB: ");
            double xB = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите координаты точки yB: ");
            double yB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки zB: ");
            double zB = Convert.ToDouble(Console.ReadLine()); 
            double distance = 0; 

            distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
            Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
            
            
        }

    }
}