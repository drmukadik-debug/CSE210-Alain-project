using System;
using System.Collections.Generic;
using System.IO;

// To show creativity, this program add a leveling system.
// As the user earns more points, the user advances through different quest levels.
// The levels are:
//0-3000    = Beginning in the Quest.
//3000-6000 = Dedicated Disciple.
//6000-9000 = Eternal Champion.
// 9000+    = Master of the Quest.


class Program
{
     // This List can contain SimpleGoal, EternalGoal,
     // and ChecklistGoal objects because they all inherit from Goal.
     static List<Goal> goals = new List<Goal>();

     static int points = 0;
     static string filename = "eternalquest.txt";

     static void Main(string[] args)
    {
        int choice = 0;

        while (choice !=6)
        {
            DisplayMenu();

            Console.Write("Select a choice:");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a valid number");
                Console.WriteLine();
                continue;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                
                case 2:
                    ListGoals();
                    break;

                case 3:
                    RecordEvent();
                    break;

                case 4:
                    DisplayScore();
                    break;

                case 5:
                    SaveGoals();
                    break;

                case 6:
                    Console.WriteLine("Thank you for using Eternal Quest!");
                    break;

                case 7:
                    LoadGoals();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }

    // Displays the main menu.
    static void DisplayMenu()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("      ETERNAL QUEST        ");
        Console.WriteLine("----------------------------");


        Console.WriteLine($"your points are: {points}");
        Console.WriteLine($"Level: {GetLevel()}");
        Console.WriteLine();

        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Goal Event");
        Console.WriteLine("4. Display points");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Quit");
        Console.WriteLine("7. Load Goals");
        Console.WriteLine();
         
    }

    // Creates a new goal based on the user's selections.
    static void CreateGoal()
    {
        Console.WriteLine("Create a new Goal");
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose the type of goal: ");

        string input = Console.ReadLine();

        if (!int.TryParse(input, out int goalType))
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        // Information for every goal.
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string description = Console.ReadLine();

        Console.Write("How many points is this goal worth? ");
        int points = ReadPositiveInteger();

        if (goalType == 1)
        {
            
            Goal goal = new SimpleGoal(
                name,
                description,
                points
            );

            goals.Add(goal);
        }
        else if (goalType == 2)
        {
            
            Goal goal = new EternalGoal(
                name,
                description,
                points
            );

            goals.Add(goal);
        }
        else if (goalType == 3)
        {
            Console.Write("How many times must this goal be completed? ");
            int target = ReadPositiveInteger();

            Console.Write("How many bonus points are awarded when complete? ");
            int bonus = ReadPositiveInteger();

            
            Goal goal = new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus
            );

            goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        Console.WriteLine("Goal created successfully!");
    }

    // Displays all goals.
    static void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        Console.WriteLine();

        if (goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        // Loop through the list of Goal objects.
        for (int i = 0; i < goals.Count; i++)
        {
        
            Console.WriteLine($"{i + 1}. {goals[i].GetDisplayString()}");
        }
    }

    // Records an event for one of the user's goals.
    static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record.");
            return;
        }

        // Display the goals first.
        ListGoals();

        Console.WriteLine();
        Console.Write("Which goal did you accomplish? ");

        string input = Console.ReadLine();

        if (!int.TryParse(input, out int goalNumber))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        
        int index = goalNumber - 1;

        
        if (index < 0 || index >= goals.Count)
        {
            Console.WriteLine("That goal does not exist.");
            return;
        }

        int earnedPoints = goals[index].RecordEvent();

        points += earnedPoints;

        Console.WriteLine();
        Console.WriteLine($"You earned {earnedPoints} points!");

        if (earnedPoints > 0)
        {
            Console.WriteLine("Great job! Keep going on your Eternal Quest!");
        }
        else
        {
            Console.WriteLine("No additional points were earned.");
        }
    }

    // Displays the current score.
    static void DisplayScore()
    {
        Console.WriteLine($"Your total score is: {points}");
        Console.WriteLine($"Your current level is: {GetLevel()}");
    }
    //Determines the user's level based on their score.
    static string GetLevel()
    {
        if (points >= 9000)
        {
            return "Level 4 - Master of the Quest";
        }
        else if (points >= 6000)
        {
            return "Level 3 - Eternal Champion";
        }
        else if (points >= 3000)
        {
            return "Level 2 - Dedicated Disciple";
        }

        else
        {
            return "Level 1 - Beginning Your Quest";
        }
    }

    // Saves the score and all goals to a text file.
    static void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);

            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals and score saved successfully!");
    }

    // Loads the score and goals from the text file.
    static void LoadGoals()
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved file was found.");
            return;
        }

        goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The save file is empty.");
            return;
        }

        points = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                Goal goal = new SimpleGoal(
                    name,
                    description,
                    points,
                    isComplete
                );

                goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = new EternalGoal(
                    name,
                    description,
                    points
                );

                goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                Goal goal = new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    amountCompleted,
                    bonus
                );

                goals.Add(goal);
            }
        }

        Console.WriteLine("Goals and score loaded successfully!");
    }

    // Helper method that makes sure the user enters
    // a positive whole number.
    static int ReadPositiveInteger()
    {
        int number;

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number > 0)
            {
                return number;
            }

            Console.Write("Please enter a positive number: ");
        }
    }
}
