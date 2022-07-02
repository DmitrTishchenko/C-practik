// Задача 23: Напишите программу, которая принимает на вход
//            число (N) и выдаёт таблицу кубов чисел от 1 до N.
namespace Geekbrains
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           Console.WriteLine("Введите число N: ");
           int a = Convert.ToInt32(Console.ReadLine());
           int [] cube = GetCube(a);
           for (int i = 0; i < cube.Length; i++)
           {
               Console.Write(cube[i]+ ", ");
           }
            
        }
        static int [] GetCube (int n)
        {
            int[] cube = new int [n];
            for (int i=1; i <= n; i++)
            {
                cube[i-1] = i*i*i;
            }
            return cube;
        }

    }
}