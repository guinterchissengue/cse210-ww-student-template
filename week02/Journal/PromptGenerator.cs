using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // list of questions
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who did you talk to today?",
        "What made you happy today?",
        "What did you learn today?",
        "What would you change about today?"
    };

    public string GetRandomPrompt()
    {
        // pick a random prompt
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}