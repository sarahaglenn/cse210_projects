using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Scripture
{    
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //split text into words and store as Word objects in a list
        string[] scriptureWords = text.Split(' ');
        foreach (string word in scriptureWords)
        {
                Word newWord = new Word(word);
                _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        int wordsShowing = (_words.Count - CountHiddenWords());
        if (wordsShowing < numberToHide)
        {
            numberToHide = wordsShowing;
        }
        //choose random numbers for as many words as you want to hide
        //then get the word at that index
        for (int i = 0; i < numberToHide; i++)
        {
            Random num = new Random();
            int index = num.Next(_words.Count);
            Word randomWord = _words[index];
            if (!randomWord.IsHidden())
            {
                randomWord.Hide();
            }
            else
            {
                i--;
            }
        }
    }
    public string GetDisplayText()
    {
        // concatonate each Word object from the list along with a space, and then display
        string scriptureText = "";
        foreach (Word w in _words)
        {
            scriptureText += $"{w.GetDisplayText()} ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }
    int CountHiddenWords()
    {
        int hiddenWordsCount = 0;
        foreach (Word w in _words)
        {
            if (w.IsHidden())
            {
                hiddenWordsCount += 1;
            }
        }
        return hiddenWordsCount;
    }
    public bool IsCompletelyHidden()
    {
        //check to see if all of the Word objects are hidden
        if (CountHiddenWords() == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}