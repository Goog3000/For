using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value :");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter limit :");
            int limit = int.Parse(Console.ReadLine());

            for (int i = firstValue; i < limit; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
