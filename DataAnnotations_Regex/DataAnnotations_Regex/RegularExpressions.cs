using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataAnnotations_Regex
{
    internal class RegularExpressions
    {
        public static void Display()
        {

            Regex regex = new Regex(@"a*b");  // Zero or more

            Match match = regex.Match("aa");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            else
            {
                Console.WriteLine("No matching");
            }
        }

        public static void Display1()
        {
            Regex reg = new Regex(@"a+b");
            Match match = reg.Match("ab");
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("No matched values");
            }
        }

        public static void Display2()
        {
            Regex reg = new Regex(@"a?g");
            Match match = reg.Match("aaaaafb");
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("no matched values");
            }
        }

        public static void Display3()
        {
            Regex reg = new Regex(@"^Shyam");
            Match match = reg.Match("No Shyam is good boy");
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("No matched value");
            }
        }
    }
}
