using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int largest = 0;
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userNum = Console.ReadLine();
            number = int.Parse(userNum);

            if (number != 0)
            {
                numbers.Add(number);

                if (number > largest)
                {
                    largest = number;
                }
            }
        }

        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }

        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }   
}