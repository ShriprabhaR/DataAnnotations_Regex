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
                Console.WriteLine("Matched: " + match.Value);
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
                Console.WriteLine("Matched: " + match.Value);
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
                Console.WriteLine("Matched: " + match.Value);
            }
            else
            {
                Console.WriteLine("No matched value");
            }
        }

        public static void Display4()
        {
            Regex reg = new Regex(@"Shri$");
            Match match = reg.Match("Her name is Shri");
            if (match.Success)
            {
                Console.WriteLine("Matched: " + match.Value);
            }
            else
            {
                Console.WriteLine("No matched value");
            }
        }

        public static void Display5()
        {
            Regex reg = new Regex(@"S...j");
            Match match = reg.Match("His name is Suuuraj and he is bad boys ");
            if (match.Success)
            {
                Console.WriteLine("Matched: " + match.Value);
            }
            else
            {
                Console.WriteLine("No matched value");
            }
        }

        public static void Display6()
        {
            //Regex reg = new Regex(@"[x-z]");
            Regex reg = new Regex(@"[^x-z]");
            Match match = reg.Match("xmax");
            if (match.Success)
            {
                Console.WriteLine("Matched: "+match.Value);
            }
            else
            {
                Console.WriteLine("No matched value");
            }
        }



    }
}
