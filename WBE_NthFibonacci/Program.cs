/*
 * write a method that returns the nth number in the Fibonacci sequence where n is a positive integer.
 * ie: NthFibonacci(7) returns 13.
 */

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
                    // building the output string
                    string nth = $"{input}th";
                    if (input < 11 || input > 13)
                    {
                        if (input % 10 == 1)
                            nth = $"{input}st";
                        if (input % 10 == 2)
                            nth = $"{input}nd";
                        if (input % 10 == 3)
                            nth = $"{input}rd";
                    }
                    Console.WriteLine($"\nThe {nth} number in Fibonacci sequence is {NthFibonacci(input)}");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"\n{ex.Message}");
                }
                Console.Write("\nPress Enter to try again...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int NthFibonacci(int input)
        {
                return input <= 1 ? input : NthFibonacci(input - 2) + NthFibonacci(input - 1);
        }
    }
}
