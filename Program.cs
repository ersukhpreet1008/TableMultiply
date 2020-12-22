using System;

namespace TableMultiplyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, multiply;

            
            Console.WriteLine("Enter the Table Number");
            number = Convert.ToInt32(Console.ReadLine());

            for (multiply = 1; multiply <=10; multiply++ )
            {
                Console.WriteLine("{0} * {1} = {2}", number, multiply,(number * multiply));
            }

        }
    }
}
