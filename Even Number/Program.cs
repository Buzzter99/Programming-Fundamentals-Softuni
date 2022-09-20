using System;

namespace Even_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            var input = int.Parse(Console.ReadLine());
            //int result = input;

            while (input % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");


                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(input)}");
        }
    }
}