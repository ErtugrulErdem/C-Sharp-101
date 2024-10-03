using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number (n): ");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a positive number: ");
        }

        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter word {i + 1}/{n}: ");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Words in reverse order:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(words[i]);
        }
    }
}

//In a console application, ask the user to enter a positive number (n). 
//Then ask the user to enter n words. Print the words entered by the user to the console from the end to the beginning.