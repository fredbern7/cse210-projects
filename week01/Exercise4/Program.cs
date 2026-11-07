using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        int UserNumber = -1000;
        while (UserNumber != 0)
        {
            Console.WriteLine("Enter numbers and 0 to quit");
            string input = Console.ReadLine();
            UserNumber = int.Parse(input);

            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();

        Console.WriteLine($"Average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}