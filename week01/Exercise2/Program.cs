using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();

        Console.WriteLine("Please enter the percentange: ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter;
        string sign;
        string message;
        if (percent >= 90)
        {
            letter = "A";
        } 
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        } 
        else
        {
            letter = "F";
        }

        if (percent >= 70)
        {
            message = "Congratulation, You have passed.";
        }
        else
        {
            message = "No worry, Try again next time.";
        }

        int remaining = percent%10;
        Console.WriteLine(remaining);
        
        if (remaining >=7)
        {
            sign = "+";
        }
        else if (remaining < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        
        Console.WriteLine($"You gat a {letter} {sign}");
        Console.WriteLine(message);
    }
}

// parsing string to number
// string valueInText = "42";
// int number = int.Parse(valueInText);

// example
// Console.Write("What is your favorite number? ");
// string userInput = Console.ReadLine();
// int number = int.Parse(userInput);

// number to string
// use .ToString() function of the variable
// 