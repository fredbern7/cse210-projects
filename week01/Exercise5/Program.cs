using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Enter your username: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        String userInput = Console.ReadLine();
        return int.Parse(userInput);
    }
    static int SquareNumber(int favoriteNumber)
    {
        return favoriteNumber * favoriteNumber;
    }
    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"Username is {userName}. Square root is {squareNumber}.");
    }
}