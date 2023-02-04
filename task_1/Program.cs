using System;

namespace ShortStringsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of strings in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] originalArray = new string[n];

            Console.WriteLine("Enter the strings:");
            for (int i = 0; i < n; i++)
            {
                originalArray[i] = Console.ReadLine();
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (originalArray[i].Length <= 3)
                {
                    count++;
                }
            }

            string[] shortStringsArray = new string[count];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (originalArray[i].Length <= 3)
                {
                    shortStringsArray[j] = originalArray[i];
                    j++;
                }
            }

            Console.WriteLine("Strings with length less than or equal to 3:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(shortStringsArray[i]);
            }
        }
    }
}