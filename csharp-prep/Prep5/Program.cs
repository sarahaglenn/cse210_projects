using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int favNumSq = SquareNumber(favNum);
        DisplayResult(name, favNumSq);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite integer number? ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;

        return squared;
    }

    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, your number squared is {squared}.");
    }
}