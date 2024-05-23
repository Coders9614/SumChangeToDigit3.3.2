using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumChangeToDigit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SumDigitsInString("1q2w3e is the total digts sum: ")); // Output: 6
            Console.WriteLine(SumDigitsInString("L0r3m.1p5um is the total digts sum:")); // Output: 9
            Console.WriteLine(SumDigitsInString(" the total digts sum:")); // Output: 0
            Console.ReadKey();
        }

        public static int SumDigitsInString(string input)
        {
            int sum = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    sum += int.Parse(c.ToString()); // Convert char to string, then parse to int and add to sum
                }
            }
            return sum;
        }
    }
}
