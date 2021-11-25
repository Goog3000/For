using System;

namespace ForIJ
{
    class Program
    {
        static bool primeNumber(int value)
        {
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 2; numbers[number -1]==0; i++)
            {
                if (primeNumber(i))
                {
                    int index = Array.IndexOf(numbers, 0);
                    if (index!= -1)
                    {
                        numbers[index] = i;
                    }
                }                
            }
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
