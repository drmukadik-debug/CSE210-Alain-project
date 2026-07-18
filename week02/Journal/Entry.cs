public class Entry
{
    public string _date;
    public string _promptTex;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptTex}");
        Console.WriteLine($"Answer: {_entryText}");
        Console.WriteLine();
    }

    
}

