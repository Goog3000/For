using System;

namespace ForIJ
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("i: " + i);
            }
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("j: " + j);
            }
        }
    }
}
