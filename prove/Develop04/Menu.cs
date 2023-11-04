using System;

public class Menu
{
    private readonly List<string> _Options = new()
    {
        "Start breathing activity",
        "Start listing activity",
        "Start reflecting activity",
        "Quit"
    };
    private int _Choice = 0;                                           
    public void DisplayMenu()
    {  
        while (_Choice!=4) 
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            int i=1;
            foreach (string option in _Options)
            {
                //iterate through the list to display each entry
                Console.WriteLine($"{i}. {option}");
                i++;
            }
            Console.WriteLine("Select a achoice from the menu:");
            _Choice =  int.Parse(Console.ReadLine());
            int activityDuration;
            Console.Clear();
            //Switch to select the option and the method to execute according to the option
            switch(_Choice)
            {
                case 1:
                    var breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.SetDuration();
                    activityDuration = int.Parse(breathingActivity.GetDuration());
                    Console.Clear();
                    breathingActivity.RunActivity(activityDuration);
                    Console.WriteLine("\nWell done!!");
                    BreathingActivity.ShowSpinner();
                    breathingActivity.DisplayEndingMessage();
                    BreathingActivity.ShowSpinner();
                    break;
                case 2:
                    var reflectingActivity = new ReflectingActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.SetDuration();
                    activityDuration = int.Parse(reflectingActivity.GetDuration());
                    Console.Clear();
                    reflectingActivity.RunReflectionActivity(activityDuration);
                    Console.WriteLine("\nWell done!!");
                    ReflectingActivity.ShowSpinner();
                    reflectingActivity.DisplayEndingMessage();
                    ReflectingActivity.ShowSpinner();
                    break;
                case 3:
                    var listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.DisplayStartingMessage();
                    listingActivity.SetDuration();
                    activityDuration = int.Parse(listingActivity.GetDuration());
                    Console.Clear();
                    listingActivity.RunListingActivity(activityDuration);
                    Console.WriteLine("\nWell done!!");
                    ListingActivity.ShowSpinner();
                    Console.WriteLine("\n");
                    listingActivity.DisplayEndingMessage();
                    ListingActivity.ShowSpinner();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Unrecognized option, please enter an integer value from 1 to 4!");
                    break;
            }
        }
    }
}