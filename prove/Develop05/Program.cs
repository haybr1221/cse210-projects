using System;
using System.IO; 

class Program
{
    public static List<string> goals = new List<string>();

    static void Main(string[] args)
    {
        int score = 0;
        bool quit = false;

        File file = new File();
        SimpleGoal simple = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        ChecklistGoal checklist = new ChecklistGoal();

        while(quit != true)
        {
            Console.WriteLine($"\nYou have {score} points.");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create a New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                // Create a new goal
                Console.WriteLine("\nThe types of goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("Which type of goal do you want to create?: ");
                int goal = int.Parse(Console.ReadLine());

                if (goal == 1)
                {
                    // create new simple
                    string newSimple = simple.CreateGoal();
                    // add to list
                    goals.Add(newSimple);
                }
                else if (goal == 2)
                {
                    // create new eternal
                    string newEternal = eternal.CreateGoal();
                    // add to list
                    goals.Add(newEternal);
                }
                else if (goal == 3)
                {
                    // create new checklist
                    string newChecklist = checklist.CreateGoal();
                    // add to list
                    goals.Add(newChecklist);
                }
            }
            else if (input == 2)
            {
                int num = 0;
                Console.WriteLine("The goals are:");
                // List goals
                foreach (string g in goals)
                {
                    num++;
                    Console.Write($"\n{num}. ");
                    if (g.StartsWith("Simple"))
                    {
                        simple.Display(g);
                    }
                    if (g.StartsWith("Eternal"))
                    {
                        eternal.Display(g);
                    }
                    if (g.StartsWith("Checklist"))
                    {
                        checklist.Display(g);
                    }
                }
                Console.WriteLine();
                
            }
            else if (input == 3)
            {
                // Save Goals
                file.SaveGoals(score, goals);
            }
            else if (input == 4)
            {
                // Load Goals and set the score
                score = file.LoadGoals(goals);
            }
            else if (input == 5)
            {
                // Record Event
                int num = 0;
                foreach (string g in goals)
                {
                    num++;
                    Console.Write($"\n{num}. ");
                    if (g.StartsWith("Simple"))
                    {
                        simple.Display(g, "n");
                    }
                    if (g.StartsWith("Eternal"))
                    {
                        eternal.Display(g, "n");
                    }
                    if (g.StartsWith("Checklist"))
                    {
                        checklist.Display(g, "n");
                    }
                }

                Console.Write("\nWhich goal did you accomplish? ");
                int recordGoal = int.Parse(Console.ReadLine());

                string goal = goals[recordGoal-1];

                if (goal.StartsWith("SimpleGoal:"))
                {
                    // Exceeding requirements: if a simple goal has already been recorded, 
                    // points will not be added and it will give the user a message
                    // reminding them that it has already been completed.
                    score = simple.RecordEvent(score, goal);
                    goals[recordGoal-1] = simple.MarkComplete(goal);
                }
                else if (goal.StartsWith("EternalGoal:"))
                {
                    score = eternal.RecordEvent(score, goal);
                }
                else if (goal.StartsWith("ChecklistGoal:"))
                {
                    score = checklist.RecordEvent(score, goal);
                    goals[recordGoal-1] = checklist.CompleteTask(goal);
                }
            }
            else if (input == 6)
            {
                // Quit
                quit = true;
            }
        }
    }
}