using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            numbers.Add(number);
        } while (number != 0);

        int total = numbers.AsQueryable().Sum();
        Console.WriteLine($"Sum: {total}");

        int avg = total / numbers.Count;
        Console.WriteLine($"Average: {avg}");

        int max = 0;
        foreach (int num in numbers)
        {
            if (max < num)
            {
                max = num;
            }
        }

        Console.WriteLine($"Max: {max}");

    }
}