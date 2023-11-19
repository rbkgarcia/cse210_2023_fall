using System;

//abstract class goal
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    
    // setters
    public void SetName() 
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
    }
    public void SetPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    // getters
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    // geters
    public int GetPoints()
    {
        return _points;
    }

    //void Record event abstract class
    public abstract void RecordEvent();
    //void isComplete abstract class method
    public abstract void IsComplete();
} 

