using System;

public class Activity 
{
    private readonly string _ActivityName;
    private readonly string _Description;
    private int _Duration;
    public Activity(string activityName, string description)
    {
        _ActivityName = activityName;
        _Description = description;
    }
    
    public string GetActivityName()
    {
        return _ActivityName;
    }

    public string GetDescription()
    {
        return _Description;
    }
    
    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = int.Parse(Console.ReadLine());
        _Duration = duration;
    }
    
    public string GetDuration()
    {
        return _Duration.ToString();
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_ActivityName} Activity!");
        Console.WriteLine(_Description);
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_Duration} seconds of the {_ActivityName} Activity.");
    }
    
    public static void ShowSpinner()
    {
        for (int i = 0; i < 2; i++) 
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    
    public static void CountDownTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}