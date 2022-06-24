namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
           
           Console.WriteLine("Введите целое число A: ");
           int numberA = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Введите целое число B: ");
           int numberB = Convert.ToInt32(Console.ReadLine());

           
        
           if (numberA > numberB)
            {
                int max = numberA;
                int min = numberB;
                Console.Write("max = ");
                Console.WriteLine(max);

                Console.Write("min = ");
                Console.WriteLine(min);

            }
            if (numberB > numberA)
            {
                int max = numberB;
                int min = numberA;
                Console.Write("max = ");
                Console.WriteLine(max);

                Console.Write("min = ");
                Console.WriteLine(min);
            }
            if (numberA == numberB)
            {
                Console.Write("Числа равны");
            }
        

        }
    }
}