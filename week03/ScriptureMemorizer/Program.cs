using System;
using System.Collections.Generic;

// Main program class
// For more creativity: 
// 1. I use a library of scriptures instead of one scripture.
// 2. The program will randomly chooses one scripture each time.

class Program
{
    static void Main(string[] args)
    {
        // Create a Random object to choose a scripture.
        Random random = new Random();

         // Create a list to store multiple scriptures.
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("Matthew",3,16),
                "But I say unto you, Love your enemies, bless them that curse you, do good to them that hate you, and pray for them which despitefully use you, and persecute you;"),
            
            new Scripture(
                new Reference("2 Nephi",2,27),
                "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seek that all men might be miserable like unto himself."),
            new Scripture(
                new Reference("Doctrine and covenants",1,38),
                "What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."),
        };

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit': ");

            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Congratulation! All the words are hidden.");
    }
}