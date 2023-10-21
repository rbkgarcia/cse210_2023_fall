using System;
using System.IO; 
public class Journal
{
    //Parameters of the class including a list of Entry and a String related to the name of the file where will be saved the journal
    public List <Entry> _journalEntries = new List<Entry>();
    public string _journalFileName;
    //Methods of the class
    public void AddEntry()
    {
        //Add an entry to the List of entries
        var newEntry = new Entry();
        newEntry.GenerateEntry();
        this._journalEntries.Add(newEntry);
    }
    public void GenerateOwnEntry(){
        Console.WriteLine("What is yout new prompt?");
        var newEntry = new Entry
        {
            _entryPrompt = new PromptGenerator().AddOwnPrompt()
        };
        Console.WriteLine(newEntry._entryPrompt);
        newEntry._entryResponse = Console.ReadLine();
        this._journalEntries.Add(newEntry);
    }
    public void DisplayEntries() {
        //Display entries in List of entries
        foreach (Entry entry in this._journalEntries)
        {
            //iterate through the list to display each entry
            Console.WriteLine($"Date: {entry._entryDate} - Prompt: {entry._entryPrompt} \n{entry._entryResponse}");
        }
    }
    public void SaveJournal(){
        Console.WriteLine("What is the filename?");
        this._journalFileName = Console.ReadLine();//let user to state name of the file to save the Journal 
        using StreamWriter outputFile = new StreamWriter(_journalFileName);//State the output of the file

        // Add the content to the file with the WriteLine method
        foreach (Entry entry in this._journalEntries)
        {
            //iterate through the list to display each entry
            outputFile.WriteLine($"Date: {entry._entryDate} - Prompt: {entry._entryPrompt} - {entry._entryResponse}");
        }
    }
    public void LoadJournalFile(){
        //Load the journal from a file
        Console.WriteLine("What is the filename?");
        this._journalFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_journalFileName);
        //Replace any entries currently stored the journal
        this._journalEntries = new List<Entry>();
        foreach (string line in lines)
        {
            var entry = new Entry();
            string[] parts = line.Split(':','-');
            entry._entryDate = parts[1].Trim();
            entry._entryPrompt = parts[3].Trim();
            entry._entryResponse=parts[4].Trim();
            this._journalEntries.Add(entry);
        }
        DisplayEntries();
    }
    public void Menu(){
        //Display and provide a menu that allows the user choose betwen write, display, save, load and quit options
        var selectedOption= "";
        //loop to iterate menu options and actions
        while (selectedOption!="6") 
        {
            Console.WriteLine("Please select one of the following choices:");
            List<string> menuOptions = new List<string>
            {
                "1. Write sugested entry",
                "2. Write own entry", 
                "3. Display",
                "4. Save",
                "5. Load",
                "6. Quit",
            };
            foreach (string option in menuOptions)
            {
                //iterate through the list to display each entry
                Console.WriteLine(option);
            }
            Console.WriteLine("What would you like to do?");
            selectedOption =  Console.ReadLine();
            //Switch to select the option and the method to execute according to the option
            switch(selectedOption)
            {
                case "1":
                    //Write an entry and save it to the entry list
                    AddEntry();
                    break;
                case "2":
                    //Write own entry ans save it to the entry list
                    GenerateOwnEntry();

                    break;
                case "3":
                    //Display the entries
                    DisplayEntries();
                    break;
                case "4":
                    //Write entries in an file and save it 
                    SaveJournal();
                    break;
                case "5":
                    //Read entries in an file and save these entries in the entry list  
                    LoadJournalFile();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Unrecognized option, please enter an integer value from 1 to 6!");
                    break;
            }
        }
    }
}