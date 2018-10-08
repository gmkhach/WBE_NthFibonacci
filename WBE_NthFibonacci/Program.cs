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
                    Console.Write("\nPress Enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
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
            List<int> sequence = new List<int>();
            for (int i = 0; i < n; i++)
            {
                sequence.Add(i < 2 ? 1 : sequence[i - 2] + sequence[i - 1]);
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
            Console.WriteLine($"\nThe {nth} number in fibonacci sequence is {sequence.Last()}");
        }
    }
}
