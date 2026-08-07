using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _duration;

    protected Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }
        
    protected void DisplayStartingMessage()
    {
        Console.Clear();
        
        Console.WriteLine($"---{_activityName} Activity---");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        Console.Write("How long in seconds, would you like for your session? ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer for the duration.");
            Console.Write("How long in seconds, would you like for your session? ");
        }
        
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>
        {
            "|", "/", "-", "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index++;
            if (index >= spinner.Count)
            {
                index = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
}
     