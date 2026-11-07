using System;

class Program {
    static void Main(string[] args) {


        Random generateNumuber = new Random();
        int magicNumber = generateNumuber.Next(1, 100);
        

        string stop = "yes";

        while (stop == "yes")
            {
                int guess = -1;
                int count = 0;

                while (guess != magicNumber) {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count += 1;

                if (magicNumber > guess) {
                    Console.WriteLine("Higher");
                } else if (magicNumber < guess) {
                    Console.WriteLine("Lower");
                } else {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You have guessed ${count} time(s)!");
            Console.WriteLine();
            Console.Write("Still want to play? (yes/no) ");
            stop = Console.ReadLine();
        }
    }
}