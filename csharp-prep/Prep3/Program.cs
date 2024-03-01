using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 0;
        int guessCount = 0;

        do
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);
            guessCount += 1;

            if (guess == magicNumber)
            {
                Console.WriteLine($"You have guessed the magic number in {guessCount} guesses!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        } while (guess != magicNumber);
    }
}