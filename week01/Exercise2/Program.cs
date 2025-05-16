using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade porcentage? ");
        string u_numer = Console.ReadLine();
        int number = int.Parse(u_numer);

        string grade = "";
        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (number >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the course with a grade of {grade}");
        }
        else
        {
            Console.WriteLine($"Your grade is {grade}. Don't give up! Better luck next time!");
        }
    }
}