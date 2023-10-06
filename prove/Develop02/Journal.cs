using System;
using System.IO; 
public class Journal
{
    //Parameters of the class including a list of Entry and a String related to the name of the file where will be saved the journal
    public List <Entry> _JournalEntries = new List<Entry>();
    public string _JournalFileName;
    //Methods of the class
    public void AddEntry()
    {
        //Add an entry to the List of entries
        var NewEntry = new Entry();
        NewEntry.GenerateEntry();
        this._JournalEntries.Add(NewEntry);
    }
    public void DisplayEntries() {
        //Display entries in List of entries
        foreach (Entry entry in this._JournalEntries)
        {
            //iterate through the list to display each entry
            Console.WriteLine($"Date: {entry._EntryDate} - Prompt: {entry._EntryPrompt} \n{entry._EntryResponse}");
        }
    }
    public void SaveJournal(){
        Console.WriteLine("What is the filename?");
        this._JournalFileName = Console.ReadLine();//let user to state name of the file to save the Journal 
        using StreamWriter outputFile = new StreamWriter(_JournalFileName);//State the output of the file

        // Add the content to the file with the WriteLine method
        foreach (Entry entry in this._JournalEntries)
        {
            //iterate through the list to display each entry
            outputFile.WriteLine($"Date: {entry._EntryDate} - Prompt: {entry._EntryPrompt} - {entry._EntryResponse}");
        }
    }
    public void LoadJournalFile(){
        //Load the journal from a file
        Console.WriteLine("What is the filename?");
        this._JournalFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_JournalFileName);
        //Replace any entries currently stored the journal
        this._JournalEntries = new List<Entry>();
        foreach (string line in lines)
        {
            var entry = new Entry();
            string[] parts = line.Split(':','-','\n');
            entry._EntryDate = parts[1].Trim();
            entry._EntryPrompt = parts[3].Trim();
            entry._EntryResponse=parts[4].Trim();
            this._JournalEntries.Add(entry);
        }
        DisplayEntries();
    }
    public void Menu(){
        //Display and provide a menu that allows the user choose betwen write, display, save, load and quit options
        int selectedOption= 0;
        //loop to iterate menu options and actions
        while (selectedOption!=5) 
        {
            Console.WriteLine("Please select one of the following choices:");
            List<string> MenuOptions = new List<string>
            {
                "1. Write", 
                "2. Display",
                "3. Save",
                "4. Load",
                "5. Quit",
            };
            foreach (string option in MenuOptions)
            {
                //iterate through the list to display each entry
                Console.WriteLine(option);
            }
            Console.WriteLine("What would you like to do?");
            selectedOption =  Int32.Parse(Console.ReadLine());
            //Switch to select the option and the method to execute according to the option
            switch(selectedOption)
            {
                case 1:
                    //Write an entry and save it to the entry list
                    AddEntry();
                    break;
                case 2:
                    //Display the entries
                    DisplayEntries();
                    break;
                case 3:
                    //Write entries in an file and save it 
                    SaveJournal();
                    break;
                case 4:
                    //Read entries in an file and save these entries in the entry list  
                    LoadJournalFile();
                    break;
                default:
                    break;
            }
        }
    }
}