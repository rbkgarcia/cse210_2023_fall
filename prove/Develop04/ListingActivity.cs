using System;

public class ListingActivity : Activity
{
    private readonly List<string> _Prompt;
                                        
    public ListingActivity(string activityName, string description):base(activityName, description)
    {
        _Prompt = new() 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public string GetPrompt() 
    {
        var listIndex = new Random().Next(this._Prompt.Count);
        return _Prompt[listIndex];  
    }
    
    public void RunListingActivity(int activityDuration)
    {
        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(activityDuration);
        TimeSpan duration2 = TimeSpan.FromSeconds(activityDuration-4);
        Console.WriteLine("Get ready...");
        ListingActivity.ShowSpinner();
        while (DateTime.Now - startTime < duration)
        {
            List<string> listeditems = new();
            Console.WriteLine(GetPrompt());
            Console.WriteLine("You may begin in:");
            ListingActivity.CountDownTimer();
            while (DateTime.Now - startTime < duration2)
            {
                var answer = Console.ReadLine();
                listeditems.Add(answer);
            }
            Console.WriteLine($"You listed {listeditems.Count} items");
        }
    }

}