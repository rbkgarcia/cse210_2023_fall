using System;
public class PromptGenerator
{
    //Parameters of the class including a list of prompt and a String related to a single promt
    public List<string> _Prompts= new List<string>()
                    {
                        "Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?"                   
                    };
    public string _Prompt;
    //Methods of the class
    public string GeneratePrompt()
    {
        //Generate a Random prompt from the list of Prompts and return it as string
        var ListIndex = new Random().Next(_Prompts.Count);
        this._Prompt = _Prompts[ListIndex];
        return _Prompt;
    }
}