using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User Registration");
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                ValidateUserInput(name, email, password);
                Console.WriteLine("Registration Successful");
            }
            catch(ValidationException e)
            {
                Console.WriteLine("Error"+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception"+e.Message); 
            }
        }
        static void ValidateUserInput(string name, string email, string password)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ValidationException("Name cannot be null");
            }
            if(string.IsNullOrEmpty(email))
            {
                throw new ValidationException("Email cannot be empty");            }
            if(string.IsNullOrEmpty(password))
            {
                throw new ValidationException("Password cannot be empty");
            }
           
            if(password.Length < 6)
            {
                throw new ValidationException("Password must be atleast of 6 length");
            }
           
        }

    }
}
