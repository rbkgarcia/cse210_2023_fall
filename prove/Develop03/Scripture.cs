using System;
using System.IO; 
public class Scripture
{
    //Attributes of the class including a list of Verses, a Reference, and a boolean to know if all verse are hidden
    private List <Verse> _scriptureVerses = new List<Verse>();
    private Reference _scriptureReference = new Reference();
    private bool _allVersesHidden = false;

    //Methods of the class
    public Reference GetReference()
    {
        //get reference
        return this._scriptureReference;
    }
    public List<Verse> GetVerses()
    {
        //get list of verses
        return this._scriptureVerses;
    }
    public void SetScripture(string newReference, List<String> newVerses){
        //set reference and list of verses
        this._scriptureReference.SetReference(newReference);
        foreach (string verse in newVerses)
        {
            var verseOfReference = new Verse(); 
            verseOfReference.SetVerse(verse);
            this._scriptureVerses.Add(verseOfReference);
        }
    }
    public void HideWords() {
        //hide random words from random verse
        var listIndex = new Random().Next(this._scriptureVerses.Count);
        var verseToHide = this._scriptureVerses[listIndex];

        if (this._scriptureVerses[listIndex].VerseHidden()!=true){
            verseToHide.HideWordInVerse();
            verseToHide.VerseHidden();
        }
        else{
            HideWords();
        }
    }
    public void ShowRenderedText(){
        //display scripture    
        this._scriptureReference.DisplayReference();
         foreach (Verse verse in this._scriptureVerses)
        {
            verse.GetVerseRendered();
        };
    }
    public bool VerseIsCompletelyHidden(){
        //verify is all words in all verses are hidden
        var Count = 0;
        foreach (Verse verse in this._scriptureVerses)
        {
            if (verse.VerseHidden() ==true){
                Count++;
            };
        }
        if(Count == this._scriptureVerses.Count){
            this._allVersesHidden = true; //set all verse hidden attribute to true
            return true;
        }
        else{
            this._allVersesHidden = false;
            return false;
        }
    }   
}