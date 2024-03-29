// Ideas for extending:
// move completed goals to the top
// Level up after completing a certain number of goals or getting a certain number of points-store that level or rank with the score
// Display something fun on the screen when a checklist goal has been completed. Or different things for each goal (polymorphism)
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalTracker = new GoalManager();
        goalTracker.Start();
    }
}