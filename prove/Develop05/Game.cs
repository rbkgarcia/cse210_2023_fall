using System;
//Game class
public class Game
{
    //attributes including menu, options, level, score, file
    // private int _level;
    // private int _score;
    // private string _Statusfile;
    // private string _Goalsfile;
    private readonly List<string> _MenuOptions = new()
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };
    private readonly List<string> _GoalOptions = new()
    {
        "Simple Goal",
        "Eternal Goal",
        "CheckList Goal",
        "Negative Goal"
    };
    private readonly List<Goal> _Goals = new();
    private int _Choice = 0;  
 public static void DisplayGoals(){
        Console.WriteLine("Press any key to continue...");     
        // int j=1;
        // foreach (Goal goal in _Goals)
        // {
        //     //iterate through the list to display each entry
        //     Console.WriteLine($"{j}. {goal.GetName()}");
        //     j++;
        // }
    }
    public void StateGoal()
    {
        int j=1;
        foreach (string option in _GoalOptions)
        {
            //iterate through the list to display each entry
            Console.WriteLine($"{j}. {option}");
            j++;
        }
        Console.WriteLine("Wich type of Goal you would like to create?  ");
        var goalType = int.Parse(Console.ReadLine());
        switch(goalType)
        {
            case 1:
                //instance of simple goal
                var simpleGoal = new SimpleGoal();
                _Goals.Add(simpleGoal);
                break;
            case 2:
                //instance of eternal goal
                // var eternalGoal = new EternalGoal();
                // _Goals.Add(eternalGoal);
                break;
            case 3:
                //instance of checklist goal
                // var checklistGoal = new CheckListGoal();
                // _Goals.Add(checklistGoal);
                break;
            case 4:
                //instance of negative goal
                // var negativeGoal = new NegativeGoal();
                // _Goals.Add(negativeGoal);
                break;
            default:
                Console.WriteLine("Unrecognized option, please enter an integer value from 1 to 4!");
                break;
        }                
    }
    public void RunGame()
    {
        while (_Choice!=6) 
        {
            Console.WriteLine("Menu Options:");
            int i=1;
            foreach (string option in _MenuOptions)
            {
                //iterate through the list to display each entry
                Console.WriteLine($"{i}. {option}");
                i++;
            }
            Console.WriteLine("Select a choice from the menu:");
            _Choice =  int.Parse(Console.ReadLine());
            //Switch to select the option and the method to execute according to the option
            switch(_Choice)
            {
                case 1:
                    StateGoal();
                    Console.Clear();
                    break;
                case 2:
                    foreach (Goal goal in _Goals)
                    {
                        goal.DisplayGoal();
                    }
                    ;      
                    break;
                case 3:
                  Console.WriteLine("3");      
                    break;
                case 4:
                Console.WriteLine("4");      
                    break;
                case 5:
                Console.WriteLine("5");      
                    break;
                case 6:
                Console.WriteLine("6");      
                    break;
                default:
                    Console.WriteLine("Unrecognized option, please enter an integer value from 1 to 4!");
                    break;
            }
        }
    }
    // //get score
    // public int GetScore()
    // {
    //     return _score;
    // }
    // //get level
    // public int GetLevel()
    // {
    //     return _level;
    // }
    // //display point method
    // public void DisplayPoints()
    // {
    //     Console.WriteLine("You have" + _score+ " points");
    //     Console.WriteLine("Your Level is: " + _level);
    // }
}
