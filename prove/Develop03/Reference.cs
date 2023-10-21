using System;
public class Reference
{
    //Parameters of the class including the reference
    private string _reference;

    //Methods of the class
    public string GetReference()
    {
        //return the Reference
        return _reference; 
    }
    public void SetReference(string newReference)
    {
        //set _reference
        this._reference= newReference;
    }
    public void DisplayReference()
    {
        //display reference
         Console.WriteLine(_reference +": ");
    }
}