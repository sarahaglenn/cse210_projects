using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "";
        int chapter = 0;
        int startVerse = 0;
        int endVerse = 0;
        string text = "";
        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, text);
    }
}