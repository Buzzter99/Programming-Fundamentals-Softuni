using System;

namespace MultiplicationTable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var result = secondNumber;
            if (secondNumber > 10)
                Console.WriteLine($"{number} X {secondNumber} = {number * secondNumber}");
            else
                for (var i = 1; i <= 10; i++)
                {
                    if (result > 10) break;
                    var res = number * i;
                    Console.WriteLine($"{number} X {result} = {number * result}");
                    result++;
                }
        }
    }
}