using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace DataAnnotations_Regex
{
    internal class Regexpression
    {
        public static void RegularExp()
        {
            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Age");
            string Age = Console.ReadLine();

            Console.WriteLine("Enter Mobile");
            string Mobile = Console.ReadLine();

            Console.WriteLine("Enter ZipCode");
            string Zipcode = Console.ReadLine();

            bool ValidName = IsNameValid(Name);
            bool ValidAge = IsAgeValid(Age);
            bool ValidMobile = IsMobileValid(Mobile);
            bool ValidZipCode = IsZipCodeValid(Zipcode);

            if (ValidName && ValidAge && ValidMobile && ValidZipCode)
            {
                Console.WriteLine("Entered data is valid");

            }

            else
            {
                if (!ValidName)
                {
                    Console.WriteLine("Name should Starts with caps and minimum 3 letters");
                }
                if (!ValidAge)
                {
                    Console.WriteLine("Age should between 18 and 60");
                }
                if(!ValidMobile)
                {
                    Console.WriteLine("Max 10 numbers only allowed");
                }
                if (!ValidZipCode)
                {
                    Console.WriteLine("Minimum length should be 5 and maximum length should be 6");
                }
            }

        }
        public static bool IsNameValid(string name)
        {
            string Pattern = @"^[A-Z][a-zA-Z]{2,50}";
            return Regex.IsMatch(name, Pattern);

        }
        public static bool IsAgeValid(String age) 
        {
            string Pattern = @"^\d+$";
            if(Regex.IsMatch(age, Pattern))
            {
                int Validage = int.Parse(age);
                return Validage>=18 && Validage<=60;
            }
            return false;
        }

        public static bool IsMobileValid(String mobile)
        {
            string Pattern = @"^\d{10}$";
            return Regex.IsMatch(mobile, Pattern);
        }

        public static bool IsZipCodeValid(String zipcode)
        {
            string Pattern = @"^\d{5,6}$";
            return Regex.IsMatch(zipcode, Pattern);
            
        }
    }
}
