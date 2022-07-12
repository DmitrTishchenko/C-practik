// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
namespace GeekBrains
{
    class HomeWork
    {
        public static int[] FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-99, 100);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    sum = sum + 1;
                }
                
            }
            Console.WriteLine(sum);
        }

       
        public static void Main()
        {
            Console.Clear();
            // объявление динамического массива M   
            Console.Write("Введите число элементов массива M = ");
            int size = int.Parse(Console.ReadLine());
            int[] arrayM = new int[size];

            FillArray(arrayM);
            Console.WriteLine();
            PrintArray(arrayM);
            Console.WriteLine();
            Console.Write("Колличество чисел массива больше нуля = ");

            SumArray(arrayM);


            
        }
    }
} 