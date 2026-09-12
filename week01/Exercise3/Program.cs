using System;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string play = "";

        while (play != "no")
        {
            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1, 100);

            int guess = -1;
            while (guess != MagicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine(MagicNumber);

                if (MagicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (MagicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
    
            Console.WriteLine("Still wanna play? yes/no: ");
            play = Console.ReadLine();
        }
    }
}