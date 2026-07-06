using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" What is the magic number?");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);
        
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int attempts = 0;

        while (guess != magicNumber)
        {
            Console.WriteLine(" What is your guess?");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            attempts++;



            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {attempts} attempts.");
            }
            
        }
    
        }
    }
