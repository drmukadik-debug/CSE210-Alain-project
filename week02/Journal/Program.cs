using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice !=5)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice from the menu ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write(">");

                string answer = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = answer;

                journal.AddEntry(entry);

                Console.WriteLine("Entry added successfully");
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);

                Console.WriteLine("journal saved successfully!");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully!");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!.");

            }
            else
            {
                Console.WriteLine("Invalid choice. Please entre a number between 1 and 5.");
            }

        }
         
    }
}