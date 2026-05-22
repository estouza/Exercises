using System;
using Password.Validators;

class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a password to validate:");
        string password = Console.ReadLine();
        if (PasswordValidator.IsValidPassword(password))
        {
            Console.WriteLine("Password is valid.");
        }
        else
        {
            Console.WriteLine("Password is invalid.");
        }
    }
}