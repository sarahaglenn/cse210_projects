using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentGrade = int.Parse(userInput);

        string letterGrade = "";
        if (percentGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (percentGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (percentGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percentGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if ((percentGrade % 10 >= 7) && (59 < percentGrade) && (percentGrade < 94))
        {
            letterGrade += "+";
        }
        else if ((percentGrade % 10 <= 3) && percentGrade > 59)
        {
            letterGrade += "-";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");
        if (percentGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass this time. Try again next semester!");    
        }
    }
}