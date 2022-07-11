// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
namespace Geekbrains
{
    public static class HomeWork
    {
        static void Main()
        {
            Console.Clear();
            // int count = new Random().Next(8);
            int[] arrayNumber = new int [5];
            Console.WriteLine("Первоночальный массив: ");
            FillArray(arrayNumber);
            Console.WriteLine();
            SumOddPosition(arrayNumber);


        }
        public static void FillArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int number = new Random().Next(1,100);
                array [i] = number;
                Console.Write(array[i]+" ");
            }
        }
        public static void SumOddPosition(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                
                if((i%2) == 0)
                {
                    sum = sum + array[i];
                }
            }
            Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = "+ sum);

        }
    }
}