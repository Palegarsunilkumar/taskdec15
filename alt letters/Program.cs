using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alt_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alternate letters from a to z:");

            for (char letter = 'a'; letter <= 'z';letter = (char) (letter + 2))
            {
                Console.Write($"{letter} ");
            }

            Console.ReadLine();
        }
    }
}
