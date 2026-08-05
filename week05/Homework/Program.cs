using System;

class Program
{
    static void Main(string[] args)
    {
        //Test the Assignment class
        Assignment assignment = new Assignment("Alain MUKADI", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        // Test the math assignment class
        MathAssignment math= new MathAssignment("Alain MUKADI", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();
        // Test the writing assignment class
        WritingAssignment writing = new WritingAssignment("Alain MUKADI", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
    }
}