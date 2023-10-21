using System;

class Program
{
    static void Main(string[] args)
    {
        //To exceed core requirements, the stretch challenge of randomly selecting only those words that are not already hidden.
        //Comments were included to understand the code. 
        //Also a more complex structure was proposed for the scriptures class that includes a list of verses instead of a single string.

        var scriptureToMemorize = new Scripture(); //instance of the Scripture object 
        string[] verses = {"Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
                            "In all thy ways acknowledge him, and he shall direct thy paths."}; //The array that contains the two verses related to the reference
        Console.Clear(); //clear console
        scriptureToMemorize.SetScripture("proverbs 3:5-6",new List<string>(verses)); //set the srcipture
        scriptureToMemorize.ShowRenderedText(); //Display the escripture
        Console.WriteLine("\nPress enter to continue or Type 'quit' to finish"); //notify about option to pres enter to hide words or write quit to end the program
        var selectedOption= ""; //variable used to determine end of the program
    
        //loop to iterate the option of hiding words or end the program
        while (selectedOption!="quit") 
        {
            selectedOption = Console.ReadLine(); //Read user input
            scriptureToMemorize.HideWords(); //Instantiate the method to hide a random word in the Scripture object's verse.
            if (scriptureToMemorize.VerseIsCompletelyHidden()==true) 
            {
                //If all the words are hidden, the program ends.
                selectedOption="quit";
            }  
            Console.Clear();
            scriptureToMemorize.ShowRenderedText();
            Console.WriteLine("\nPress enter to continue or Type 'quit' to finish");
        }
    }
}