using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the diamond (half): \n");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Upper half of the diamond
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }

        // Lower half of the diamond
        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}
