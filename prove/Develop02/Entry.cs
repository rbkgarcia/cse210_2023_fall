using System;
public class Entry
{
    //Parameters of the class including the prompt, entry, and date, all as string type
    public string _EntryResponse;
    public string _EntryPrompt;
    public string _EntryDate;
    //Methods of the class
    public void GenerateEntry()
    {
        //return a whole entry with its prompt, entry response and date
        this._EntryDate = DateTime.Now.ToShortDateString();
        this._EntryPrompt = new PromptGenerator().GeneratePrompt();
        Console.WriteLine(_EntryPrompt);
        this._EntryResponse = Console.ReadLine();
    }
}