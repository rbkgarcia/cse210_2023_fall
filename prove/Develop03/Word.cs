using System;
public class Word
{
    //Attributes of the class including the word and the attribute that notifies if the word is hidden
    private string _word;
    private bool _hidden = false; //parameter to know if word is hidden

    //Methods of the class
     public string GetRenderedText()
    {
        //return word       
        return this._word;
    }
        public bool GetHidden()
    {
        //return the hidden attribute
        return this._hidden; 
    }
    public void SetWord(string newWord)
    {
        //set word
        this._word= newWord;
    }
    public void HideWord()
    {
        //hide the word and set hidden attribute true
        this._word= "___";
        this._hidden=true;
    }
    public bool IsHide()
    {
        //return true of false if word is hidden or not
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
        Console.WriteLine(this._word +" ");
    }
}