// To extend the project, I added a ShowAnimation() method to the Goal class
// and used the concept of polymorhism to override it in the other classes 
// so that each class can have its own animation
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalTracker = new GoalManager();
        goalTracker.Start();
    }
}