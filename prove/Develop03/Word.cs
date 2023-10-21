using System;
public class Word
{
    //Parameters of the class including the word and the hide
    private string _word;
    private bool _hidden = false; //parameter to know if word is hidden

     public string GetRenderedText()
    {
       return this._word;
    }
        public bool GetHidden()
    {
        //return the word
        return _hidden; 
    }
    public void SetWord(string newWord)
    {
        //set word object
        this._word= newWord;
    }
    public void HideWord()
    {
        //hide the word
        this._word= "___";
        this._hidden=true;
    }
    public bool IsHide()
    {
        if (this._hidden==true){
            return true;
        }
        else{
            return false;
        };
    }
        public void ShowWord()
    {
        //display word
        Console.WriteLine(_word +" ");
    }
}