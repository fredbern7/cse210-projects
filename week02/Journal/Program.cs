using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is your Journal.");
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string response = "";
        while (response != "5" || response != "exit")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "5")
            {
                Console.WriteLine("Journal closed..");
                return;
            }
            else if (response == "1")
            {
                string question = promptGenerator.GetRandomPrompt();
                Console.WriteLine(question);
                string entry = Console.ReadLine();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();

                Entry anEntry = new Entry();

                anEntry._date = dateText;
                anEntry._entryText = entry;
                anEntry._promptText = question;
                theJournal.AddEntry(anEntry);
            }
            else if (response == "2")
            {
                Console.WriteLine("Display Journal..");
                theJournal.DisplayAll();
            }
            else if (response == "3")
            {
                Console.WriteLine("Enter file name: ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
                Console.WriteLine("File loaded....");
            }
            else if (response == "4")
            {
                Console.WriteLine("Enter file name: ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
                Console.WriteLine("File saved....");
            }
            else
            {
                Console.WriteLine("Please enter 1-5....");
            }

        }
    }
}