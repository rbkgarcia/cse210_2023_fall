using System;

//simpleGoal class that inherits from the abstrac class Goal

public class SimpleGoal:Goal
{
    //Attributes
    protected bool _isCompleted;
    //Constructor with name obtained from the set name method     
    public SimpleGoal()
    {
        SetName();
        this._name = GetName();
        SetDescription();
        this._description = GetDescription();
        SetPoints();
        this._points = GetPoints();
        SetIsCompleted(false);
    }
    //getters
    public bool GetIsCompleted(){
        return _isCompleted;
    }
    //setters
    public void SetIsCompleted(bool goalCompleted){
        _isCompleted = goalCompleted;
    }
    //override methods from the Goal abstrac class
    public override void IsComplete()
    {
    }
    public override void RecordEvent()
    {
    }
}
