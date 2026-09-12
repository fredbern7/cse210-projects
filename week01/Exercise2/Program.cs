using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Enter number: ");
        // string valueFromUser = Console.ReadLine();


        // // Console.WriteLine("Hello World! This is the Escoreercise2 Project.");
        // int score = int.Parse(valueFromUser);
        // int y = 2;
        
        // if (score > y)
        // {
        //     Console.WriteLine("Greater");
        // }
        // else if (score < y)
        // {
        //     Console.WriteLine("Less");
        // }
        // else
        // {
        //     Console.WriteLine("Equal");
        // }

        Console.WriteLine("Enter score: ");
        string userInput = Console.ReadLine();
        
        string letter = "";
        string sign = "";

        int score = int.Parse(userInput);
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remainder = score % 10;

        if (score >= 59 && remainder >= 7)
        {
            sign = "+";
        }
        else if (score >= 59 && remainder >= 3)
        {
            sign = "";
        }
        else
        {
            sign = "-";
        }

        string message = $"The grade is {letter}{sign}";
        Console.WriteLine(message);

        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try again next time!");
        }

    }


}