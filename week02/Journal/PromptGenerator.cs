using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What is one small victory you had today?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("How did you become a better person today?");
        _prompts.Add("What meaningful conversation did you have today?");
        _prompts.Add("If today had a title, what would it be and why?");

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}