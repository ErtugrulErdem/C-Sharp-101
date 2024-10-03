using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a sentence: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int wordCount = words.Length;

        int letterCount = 0;
        foreach (string word in words)
        {
            letterCount += word.Length;
        }

        Console.WriteLine($"Total number of words: {wordCount}");
        Console.WriteLine($"Total number of letters: {letterCount}");
    }
}