// Задача 29:  Напишите программу, которая задаёт случайный массив случайного 
//             размера элементов и выводит на экран массив квадратов этих чисел.

//             1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]

//             6, 1, 33 -> [36, 1, 1089]
namespace Geekbrains
{
    public static class HomeWork
    {
        
        public static void Main ()
        {
            Console.Clear();
            int n = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                else
                    Console.WriteLine("Неверное число.");
            }
            int [] array = new int [n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1,100);
            }
            
            Console.WriteLine("Массив: ");
            PrintArray(array, 0);
            Console.WriteLine("");
            Console.WriteLine("Квадрат массива: ");
            SquareArray(array,0);
        }
        public static void PrintArray(int[] digits, int count)
        {
            if(count == digits.Length)
            {
                return;
            }
            
            Console.Write($"{digits[count]} ");
            PrintArray(digits, count + 1);
        }
        public static void SquareArray(int[] digits, int count)
        {
            if(count == digits.Length)
            {
                return;
            }
            
            Console.Write($"{digits[count]*digits[count]} ");
            SquareArray(digits, count + 1);

        }
    }
}