using System;

namespace SampleConsoleAppWithUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new PrimeService();
            for (int i = -5; i < 100; i++)
            {
                var result = (svc.IsPrime(i)) ? true : false;
                Console.WriteLine($"{i} is a Prime? {result}");
            }
        }
    }
}
