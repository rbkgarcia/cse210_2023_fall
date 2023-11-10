using System;

public class BreathingActivity : Activity
{
    private readonly string _Message1;
    private readonly string _Message2;                                          
    
    public BreathingActivity(string activityName, string description):base(activityName, description)
    {
        _Message1 ="Breathe in...";
        _Message2 ="Breathe out...";
    }

    public void DisplayBreathingMessages(){
        Console.Write("\n");
        Console.Write(_Message1);
        CountDownTimer();
        Console.Write("\n");
        Console.Write(_Message2);
        CountDownTimer();
        Console.Write("\n");
    }
    
    public void RunActivity(int activityDuration){
        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(activityDuration);
        Console.WriteLine("Get ready...");
        BreathingActivity.ShowSpinner();
        while (DateTime.Now - startTime < duration)
        {
            DisplayBreathingMessages();
        }
    }
}

