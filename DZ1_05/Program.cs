namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

           Console.Clear();
           Console.WriteLine("Введите целое число: ");
           int n = Convert.ToInt32(Console.ReadLine());
           
           int firstDigit = (int)(n / Math.Pow(10, (int)Math.Log10(n)));// выводит первую цифру в числе
           int lastDigit = (int)(n % 10); //выводит последнюю цифру в числе через остаток 
           
           
           Console.Write(lastDigit);
        }
    }
}