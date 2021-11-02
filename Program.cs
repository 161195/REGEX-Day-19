using System;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program");
            Console.WriteLine();
            
            Console.Write("Enter First Name : ");   //taking user input of first name
            string firstname = Console.ReadLine();

            RegexValidate.FirstName(firstname);
            Console.ReadLine();

        }
    }
}
