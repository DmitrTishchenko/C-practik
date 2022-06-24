namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

           Console.WriteLine("Введите целое число A: ");
           int a = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Введите целое число B: ");
           int b = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Введите целое число C: ");
           int c = Convert.ToInt32(Console.ReadLine());

           int max = Math.Max(Math.Max(a, b), c);

        
            Console.Write("max = ");
            Console.WriteLine(max);
            
            

        }
    }
}