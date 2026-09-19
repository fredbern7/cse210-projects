using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        string sentence = "Trust in the Lord with all thine heart";

        // 1. Split the sentence into individual words based on spaces
        string[] words = sentence.Split(' ');

        // 2. Create a random number generator
        Random random = new Random();

        // 3. Pick a random word index from the array
        int randomIndex = random.Next(0, words.Length);
        string randomWord = words[randomIndex];

        // 4. Create the underscores matching the length of that random word
        string underscores = new string('_', randomWord.Length);

        // 5. Replace that specific word in the sentence
        // (Note: this replaces all instances of that word if it appears more than once)
        string updatedSentence = sentence.Replace(randomWord, underscores);

        Console.WriteLine("Original: " + sentence);
        Console.WriteLine("Updated:  " + updatedSentence);
    }
}