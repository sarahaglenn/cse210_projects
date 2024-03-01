using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }
        int total = 0;
        foreach (int value in numbers)
        {
            total += value;
        }
        float avg = ((float)total) / (numbers.Count);
        int greatest = numbers[0];
        foreach (int value in numbers)
        {
            if (value > greatest)
            {
                greatest = value;
            }
        }
        int smallestPositive = numbers.FirstOrDefault(number => number > 0);
        foreach (int entry in numbers)
        {
            if ((entry > 0) && (entry < smallestPositive))
            {
                smallestPositive = entry;
            }
        }
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {greatest}");
        Console.WriteLine($"The smallest positie number is: {smallestPositive}");
    }
}