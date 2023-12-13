using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling(new DateTime(2023, 3, 11), 60, 10);
        Swimming swimming = new Swimming(new DateTime(2023, 3, 11), 40, 50);
        Running running = new Running(new DateTime(2023, 3, 11), 60, 5);

        //create list of activities
        List<Activity> activities = new List<Activity>();
        
        //add activities to list
        activities.Add(cycling);
        activities.Add(swimming);
        activities.Add(running);
        
        //clear window
        Console.Clear();

        //Iterate trough the list of activities
        foreach (Activity activity in activities)
        {
            //call DisplaySummary method
            activity.DisplaySummary();
        }
    }
}