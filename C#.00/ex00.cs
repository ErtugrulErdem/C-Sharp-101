using System; 

class Program
{
    static void Main()
    {
        Console.Write("Enter positive number (n): ");
        int n = int.Parse(Console.ReadLine());
        
   

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter positive numbers: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Even Numbers:");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}

// In a console application, ask the user to enter a positive number(n).
//Then ask the user to enter n positive numbers. Print the even numbers entered by the user to the console.
