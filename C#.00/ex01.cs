using System;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first positive number(n)");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a positive number for n:");
        }
        Console.Write("Enter the second positive number(m)");
        int m;
        while(!int.TryParse(Console.ReadLine(), out m) || m <= 0)
        {
            Console.Write("Please enter a positive number for m");
        }
        
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter positive number: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.Write("Please enter a positive number: ");
            }
            numbers[i] = number;
        }
        Console.WriteLine($"Numbers equal to or divisible by {m}:");
        foreach (int number in numbers)
        {
            if (number == m || m != 0 && number % m == 0)
            {
                Console.WriteLine(number);
            }
        }

    }
}

//In a console application, ask the user to enter two positive numbers (n, m). Then ask the user to enter n positive numbers.
// Print the numbers entered by the user that are divisible by or equal to m to the console.