using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void CompilePrompts()
    {
        _prompts.Add("What was a memorable moment from your day? ");
        _prompts.Add("Write about a time you felt at peace today. ");
        _prompts.Add("What was something funny that happened today?");
        _prompts.Add("Write about something you want to tell your future self. ");
        _prompts.Add("What is a problem that you solved today? ");
    }
    
    public string GetRandomPrompt()
    {
        Random num = new Random();
        string prompt =  _prompts[num.Next(_prompts.Count)];
        return prompt;
    }
}