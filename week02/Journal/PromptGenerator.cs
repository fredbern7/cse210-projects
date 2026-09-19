using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
        {
            _prompts = new List<string>(File.ReadAllLines("questions.txt"));
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            string question = _prompts[index];
            return question;
        }
}