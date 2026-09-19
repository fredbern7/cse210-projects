using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        Journal journal = new Journal();
        while ( choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    PromptGenerator question = new PromptGenerator();
                    string prompt = question.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    // Console.WriteLine("Display Journal");
                    Console.WriteLine();
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Load File");
                    Console.Write("Enter the filename: ");
                    string nameA = Console.ReadLine();
                    string fileA = $"{nameA}.txt";
                    journal.LoadFromFile(fileA);
                    break;
                case "4":
                    Console.WriteLine();
                    Console.Write("Enter the filename: ");
                    string name = Console.ReadLine();
                    string file = $"{name}.txt";
                    journal.SaveToFile(file);
                    break;
                case "5":
                    Console.WriteLine("Journal Closed!");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }

        // Write a new entry - Show the user a random prompt 
        // (from a list that you create), a
        // nd save their response, the prompt, 
        // and the date as an Entry.

        // Display the journal - 
        // Iterate through all entries in 
        // the journal and display them to the screen.

        // Save the journal to a file - 
        // Prompt the user for a filename 
        // and then save the current journal 
        // (the complete list of entries) to that file location.

        // Load the journal from a file - 
        // Prompt the user for a filename and 
        // then load the journal 
        // (a complete list of entries) from that file. 
        // This should replace any entries currently stored the journal.

        // Provide a menu that allows the user choose these options

        // Your list of prompts must contain 
        // at least five different prompts. 
        // Make sure to add your own prompts 
        // to the list, but the following 
        // are examples to help get you started:

        // -Who was the most interesting person I interacted with today?
        // -What was the best part of my day?
        // -How did I see the hand of the Lord in my life today?
        // -What was the strongest emotion I felt today?
        // -If I had one thing I could do over today, what would it be?

        // 1. Save file as .csv file, separator = ~
        // 2. Store date as string

    }
}