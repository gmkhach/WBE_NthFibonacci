using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_NthFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a positive integer\n\n>>> ");
                    int input = int.Parse(Console.ReadLine().Trim());
                    if (input < 1)
                    {
                        throw new Exception("\nInvalid Entry!");
                    }
                    NthFibonacci(input);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                Console.Write("\nPress Enter to try again...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static void NthFibonacci(int n)
        {
            List<int> sequence = new List<int>();
            for (int i = 0; i < n; i++)
            {
                // the first two numbers of the Fibonacci sequence are 1. So, if n is 1 or 2 (i.e. i is 0 or 1) the code will return 1.
                sequence.Add(i < 2 ? 1 : sequence[i - 2] + sequence[i - 1]);
            }
            // building the output string
            string nth = $"{n}th";
            if (n % 10 == 1 && n != 11 )
            {
                nth = $"{n}st";
            }
            else if (n % 10 == 2 && n != 12)
            {
                nth = $"{n}nd";
            }
            else if (n % 10 == 3 && n != 13)
            {
                nth = $"{n}rd";
            }
            Console.WriteLine($"\nThe {nth} number in fibonacci sequence is {sequence.Last()}");
        }
    }
}
