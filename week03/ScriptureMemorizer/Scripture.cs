using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
 
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string word in parts)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        foreach (Word w in _words)
        {
            text += w.GetDisplayText() + " ";
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}