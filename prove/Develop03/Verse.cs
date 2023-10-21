using System;

public class Verse
{
    //Parameters of the class including the list of words and if verse is hidden
    private List <Word> _verse = new List<Word>();
    private bool _verseHidden = false; //parameter to know if verse is hidden

    //Methods of the class
    public List<Word> GetVerse()
    {
        //return the verse
        return this._verse; 
    }
     public void SetVerse(string newVerse )
    {
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
        var listIndex = new Random().Next(_verse.Count);
        if (this._verse[listIndex].IsHide()!=true){
            this._verse[listIndex].HideWord();
            Console.WriteLine(listIndex);
            Console.WriteLine(this._verse[listIndex]);
        }
        else{
            HideWordInVerse();
        }
    }
    public void GetVerseRendered()
    {
        foreach (Word word in _verse)
        {
            var i = word.GetRenderedText();
            Console.Write($"{i} ");
        }
    }
    public bool VerseHidden()
    {
        var Count = 0;
        foreach (Word word in _verse)
        {
            if (word.IsHide() ==true){
                Count++;
            };
        }
        if(Count== _verse.Count){
            this._verseHidden = true;
            return true;
        }
        else{
            this._verseHidden = false;
            return false;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}