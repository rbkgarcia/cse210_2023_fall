using System;

public class Verse
{
    //Attributes of the class including the list of words and if verse is hidden
    private List <Word> _verse = new List<Word>();
    private bool _verseHidden = false; //attribute to know if verse is hidden

    //Methods of the class
    public List<Word> GetVerse()
    {
        //return the verse
        return this._verse; 
    }
     public void SetVerse(string newVerse )
    {
        //set verse's list of words from a string
        var wordList= newVerse.Split(" ").ToList();
        foreach (string word in wordList)
        {
            var wordInVerse = new Word(); 
            wordInVerse.SetWord(word);
            this._verse.Add(wordInVerse);
        }
    }
    public void HideWordInVerse()
    {
        //Hide random words from the list without repeating them (stretch challenge)
        var listIndex = new Random().Next(this._verse.Count);
        if (this._verse[listIndex].IsHide()!=true){
            this._verse[listIndex].HideWord();
        }
        else{
            HideWordInVerse();
        }
    }
    public void GetVerseRendered()
    {
        //Display rendered verse
        foreach (Word word in this._verse)
        {
            var i = word.GetRenderedText();
            Console.Write($"{i} ");
        }
    }
    public bool VerseHidden()
    {
        //Set the attribute that notifies if all words are hidden
        var Count = 0;
        foreach (Word word in this._verse)
        {
            if (word.IsHide() ==true){
                Count++;
            };
        }
        if(Count== this._verse.Count){
            this._verseHidden = true;
            return true;
        }
        else{
            this._verseHidden = false;
            return false;
        }
    }
}