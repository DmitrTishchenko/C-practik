namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
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