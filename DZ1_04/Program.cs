﻿namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
           Console.Clear();
           Console.WriteLine("Введите целое число: ");
           int N = Convert.ToInt32(Console.ReadLine());
           int count = 1;
           
           Console.Write("Четные числа: ");
           while (count < N+1)
           
           {
               
           

                if ((count%2) == 0)
                
                    
                Console.Write($"{count} ");
                count++;
                
              
           }

        }
    }
}