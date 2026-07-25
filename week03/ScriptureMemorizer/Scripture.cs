using System;
using System.Collections.Generic;
using System.Linq;
// Scripture class represent an entire scripture, 
// including its reference and all of its words.
public class Scripture
{
    // Store the scripture reference
    private Reference _reference;
    
    // Store every word as a Word object.
    private List<Word> _words;
    // Random object used for selecting words.
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = text
            .Split(' ')
            .Select(w => new Word(w))
            .ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(_words.Count);

            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} " +
               $"{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

}

