using System;
using System.Collections.Concurrent;
public class Reference
{
    public Reference(string book, int chapter, int verse)
    {
        string _book = book;
        int _chapter = chapter;
        int _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        string _book = book;
        int _chapter = chapter;
        int _verse = startVerse;
        int _endVerse = endVerse;
    }
    string GetDisplayText()
    {
        return "";
    }
}