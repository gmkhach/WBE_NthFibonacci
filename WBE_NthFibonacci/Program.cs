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
            } while (true);
        }

        static void NthFibonacci(int n)
        {
            int nMinus2 = 0;
            int nMinus1 = 0;
            // sets the 1st fibonacci number
            int number = 1;
            // if n>2 calculate n
            for (int i = 0; i < n - 1; i++)
            {
                nMinus2 = nMinus1;
                nMinus1 = number;
                number = nMinus2 + nMinus1;
            }
            // building the output string
            string nth = $"{n}th";
            if (nth[nth.Length - 3] == '1' && n !=11 )
            {
                nth = $"{n}st";
            }
            else if (nth[nth.Length - 3] == '2' && n != 12)
            {
                nth = $"{n}nd";
            }
            else if (nth[nth.Length - 3] == '3' && n != 13)
            {
                nth = $"{n}rd";
            }
            Console.WriteLine($"\nThe {nth} number in fibonacci sequence is {number}");
        }
    }
}
