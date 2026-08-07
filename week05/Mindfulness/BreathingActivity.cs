using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            if (DateTime.Now >= endTime)
            {
                break;
            }
            Console.WriteLine();

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        DisplayEndingMessage();
    }
}
