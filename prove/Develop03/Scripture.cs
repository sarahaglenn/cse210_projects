using System;
using System.Collections.Generic;

public class Scripture
{    
    public Scripture(Reference reference, string text)
    {
        Reference _reference = reference;
        Word word = new Word(text);
        List<Word> _words = new List<Word>();
        //add code here about splitting the text string into a list
        //of word objects
    }
    void HideRandomWords(int numberToHide)
    {

    }
    string GetDisplayText()
    {
        return "";
    }
    bool IsCompletelyHidden()
    {
        return false;
    }
}