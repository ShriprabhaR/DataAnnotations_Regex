using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAnnotations_Regex
{
    internal class UserDetails
    {
        [Required(ErrorMessage = "name is Mandatory field")]
        public String Name { get; set; }

        [Range(18, 60, ErrorMessage = "Age should be between {1} and {2}")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Enter valid Email")]
        public String Email { get; set; }

        [Range(typeof(DateTime), "01/01/1990", "31/12/2024", ErrorMessage = "date should between {1} and {2}")]
        public DateTime DOB { get; set; }

        [DataType(DataType.Password)]
        public string Password {  get; set; }

        [Compare("Password", ErrorMessage ="Password Doesn't matched")]
        public String ConfirmPassword {  get; set; }

        public static void InputValidation()
        {
            Console.WriteLine("Enter Your Name");
            String name = Console.ReadLine();

            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Email");
            String email = Console.ReadLine();

            Console.WriteLine("Enter your DOB");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter password");
            String password = Console.ReadLine();

            Console.WriteLine("Enter Confirm password");
            String confirmPassword = Console.ReadLine();

            var user = new UserDetails
            {
                Name = name,
                Age = age,
                Email = email,
                DOB = dob,
                Password = password,
                ConfirmPassword = confirmPassword

            };

            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, results, true);

            if (isValid)
            {
                Console.WriteLine("Entered data is Valid");
                Console.WriteLine($"Name: {name}, Age: {age}, Email: {email}, DOB: {dob}, Password:{password}, Confirm: {confirmPassword}");
            }
            else
            {
                Console.WriteLine("Validation errors:-");
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

        }


    }
}
