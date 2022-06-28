
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 10: Напишите программу, которая принимает на вход трёхзначное
            //            число и на выходе показывает вторую цифру этого числа.
           Console.Clear();
           Console.WriteLine("Введите целое трехзначное число: ");
           int n = Convert.ToInt32(Console.ReadLine());

           int lastDigit = (int)(n % 100);

           int firstDigit = (int)(lastDigit / Math.Pow(10, (int)Math.Log10(lastDigit)));
           Console.Write(firstDigit);

       
        }    
 
    }
}