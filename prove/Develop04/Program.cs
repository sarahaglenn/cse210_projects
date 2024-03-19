using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity activity2 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This iwll help you recognize the power you have and how to use it in other aspects of your life.");
        ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string userChoice = "";
        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                activity1.RunActivity();
            }
            else if (userChoice == "2")
            {
                activity2.RunActivity();
            }
            else if (userChoice == "3")
            {
                activity3.RunActivity();
            }
            else
            {
                break;
            }
    
        }
    }
}