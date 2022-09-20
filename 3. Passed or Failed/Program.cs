using System;

namespace _3._Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {

            double passed = double.Parse(Console.ReadLine());

            if (passed >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }


        }
    }
}
