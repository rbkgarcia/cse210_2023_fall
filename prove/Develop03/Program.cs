using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptureToMemorize = new Scripture();  
        string[] verses = {"Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
                            "In all thy ways acknowledge him, and he shall direct thy paths."};
        scriptureToMemorize.SetScripture("Proverbs 3:5-6", new List<string>(verses));
        //Display the escripture and provide the option to enter to hide words in scripture or write quit to end the program
        var selectedOption= "";
        Console.Clear();
        scriptureToMemorize.ShowRenderedText();
        Console.WriteLine("\nPress enter to continue or Type 'quit' to finish");
        //loop to iterate menu options and actions
        while (selectedOption!="quit") 
        {
            selectedOption = Console.ReadLine();
            scriptureToMemorize.HideWords();
            if (scriptureToMemorize.VerseIsCompletelyHidden()==true){
                selectedOption="quit";
            }  
            Console.Clear();
            scriptureToMemorize.ShowRenderedText();
            Console.WriteLine("\nPress enter to continue or Type 'quit' to finish");
        }
    }
}