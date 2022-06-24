namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

           Console.WriteLine("Введите целое число: ");
           int a = Convert.ToInt32(Console.ReadLine());

           if ((a%2) == 0)
           {
               Console.WriteLine($"{ a } - число четное");
           }
           else
           {
               Console.WriteLine($"{ a } - число нечетное");
           }
           

        }
    }
}