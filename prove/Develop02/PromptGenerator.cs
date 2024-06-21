using System;
using System.Collections.Generic;

public class PromptGenerator
{
  public List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "What was the highlight of your day?",
        "What did you learn today?",
        "How did you feel today and why?",
        "What was the most challenging part of your day?"
    };

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }
}
