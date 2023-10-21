using System;
using System.IO; 
public class Scripture
{
    //Parameters of the class including a list of Verses, a Reference, and a boolean to know if all verse are hidden
    private List <Verse> _scriptureVerses = new List<Verse>();
    private Reference _scriptureReference = new Reference();
    private bool _allVersesHidden = false;

    //Methods of the class
    public Reference GetReference()
    {
        //Add an entry to the List of entries
        return _scriptureReference;
    }
    public List<Verse> GetVerses()
    {
        //Add an entry to the List of entries
        return this._scriptureVerses;
    }
    public void SetScripture(string newReference, List<String> newVerses){
        this._scriptureReference.SetReference(newReference);
        foreach (string verse in newVerses)
        {
            var verseOfReference = new Verse(); 
            verseOfReference.SetVerse(verse);
            this._scriptureVerses.Add(verseOfReference);
        }
    }
    public void HideWords() {
        var listIndex = new Random().Next(_scriptureVerses.Count);
        var verseToHide = this._scriptureVerses[listIndex];
        verseToHide.HideWordInVerse();
        verseToHide.VerseHidden();
    }
    public void ShowRenderedText(){
        this._scriptureReference.DisplayReference();
         foreach (Verse verse in this._scriptureVerses)
        {
            verse.GetVerseRendered();
        };
    }
    public bool VerseIsCompletelyHidden(){
        var Count = 0;
        foreach (Verse verse in this._scriptureVerses)
        {
            if (verse.VerseHidden() ==true){
                Count++;
            };
        }
        if(Count == _scriptureVerses.Count){
            this._allVersesHidden = true;
            return true;
        }
        else{
            this._allVersesHidden = false;
            return false;
        }
    }   
}