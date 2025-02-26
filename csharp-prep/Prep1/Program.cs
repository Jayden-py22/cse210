using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your Last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is: {firstName} {lastName}");
    }
}