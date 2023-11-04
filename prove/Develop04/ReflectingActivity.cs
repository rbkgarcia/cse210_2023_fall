using System;
using System.Dynamic;
using System.Formats.Asn1;

public class ReflectingActivity : Activity
{
    private readonly List<string> _Prompt = new();                                                 
    private List<string> _Reflections = new();                                            
    
    public ReflectingActivity(string activityName, string description):base(activityName, description)
    {
        _Prompt = new() 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _Reflections = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        }; 
    }
    
    public string GetPrompt() 
    {
        var listIndex = new Random().Next(this._Prompt.Count);
        return _Prompt[listIndex];  
    }

    public string GetReflection()
    {
        var listIndex = new Random().Next(this._Reflections.Count);
        return _Reflections[listIndex];
    }
    
    public void RunReflectionActivity(int activityDuration)
    {
        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(activityDuration);
        Console.WriteLine("Get ready...");
        ReflectingActivity.ShowSpinner();
        while (DateTime.Now - startTime < duration)
        {
            Console.WriteLine(GetPrompt());
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("You may begin in:   ");
            ReflectingActivity.CountDownTimer();
            string answer = "";
            while (answer!="")
            {
                GetReflection();
                ReflectingActivity.ShowSpinner();
                answer = Console.ReadLine();
            }
        }
    }
}