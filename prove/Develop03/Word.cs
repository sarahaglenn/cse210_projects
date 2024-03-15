using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
    _text = text;
    _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
        string hiddenText = "";
        for (int i=0; i < _text.Count(); i++)
        {
            hiddenText += "_";
        }
        return hiddenText;
        }
        else
        {
            return _text;
        }
    }
}