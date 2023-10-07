using System;
public class Entry
{
    //Parameters of the class including the prompt, entry, and date, all as string type
    public string _entryResponse;
    public string _entryPrompt;
    public string _entryDate =  DateTime.Now.ToShortDateString();
    //Methods of the class
    public void GenerateEntry()
    {
        //return a whole entry with its prompt, entry response and date
        this._entryPrompt = new PromptGenerator().GeneratePrompt();
        Console.WriteLine(_entryPrompt);
        this._entryResponse = Console.ReadLine();
    }
}