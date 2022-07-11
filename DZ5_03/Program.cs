// Задача 38: Задайте массив вещественных чисел. 
//            Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
namespace Geekbrains
{
    public static class HomeWork
    {
       static void Main(string[] args)
        {
            Console.Clear();
            Random number = new Random();
            int[] d = new int[10];
            int max=0, min=100;
            for (int i = 0; i<d.Length; i++ )  d[i] = number.Next(100);
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }
           
               for (int i = 0; i < d.Length; i++) Console.Write(d[i]+ " ");//выводим массив
               Console.WriteLine();
                 Console.WriteLine("Max:  " + max);
                 Console.WriteLine("Min:  " +min);
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));
                
        }
        
    }
}