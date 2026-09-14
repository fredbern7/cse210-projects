using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numberList = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numberList.Add(number);
            }
        }

        for (int i = 0; i < numberList.Count; i++)
        {

            Console.WriteLine(numberList[i]);
        }
        
        // The sum is:
        Console.WriteLine($"The sum is: {numberList.Sum()}");
        // The average is:
        Console.WriteLine($"The average is: {numberList.Average()}");
        // The largest number is:
        Console.WriteLine($"The Max is: {numberList.Max()}");

        //Least positive number:
        Console.WriteLine($"Least positive number: {numberList.Min(n => n > 0 ? n : null)}");
        // The sorted list is:
        numberList.Sort();
        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }
        }
    }