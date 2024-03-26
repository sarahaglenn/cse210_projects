// To extend the assignment, I made sure the questions in the 
// reflecting activity do not repeat until they have all been used
// to reflect on that experience. Similarly, for each session with 
// the program, the prompts in the reflecting activity will not 
// repeat until they have all been used. 
using System;
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity activity2 = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This iwll help you recognize the power you have and how to use it in other aspects of your life.");
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
                activity1.Run();
            }
            else if (userChoice == "2")
            {
                activity2.Run();
            }
            else if (userChoice == "3")
            {
                activity3.Run();
            }
            else
            {
                break;
            }    
        }
    }
}