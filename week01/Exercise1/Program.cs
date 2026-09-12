using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is you last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName}");

        
    }
}