// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

namespace Geekbrains
{
    public static class HomeWork
    {
        static void Main()
        {
            Console.Clear();
            int count = new Random().Next(4, 10);
            int[] arrayNumber = new int [count];
            Console.WriteLine("Первоночальный массив: ");
            FillArray(arrayNumber);
            Console.WriteLine();
            SumEvenNumber(arrayNumber);


        }
        public static void FillArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int number = new Random().Next(100,1000);
                array [i] = number;
                Console.Write(array[i]+" ");
            }
        }
        public static void SumEvenNumber(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                
                if((array[i]%2) == 0)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("Колличество четных чисел в массиве = "+ sum);

        }
    }
}