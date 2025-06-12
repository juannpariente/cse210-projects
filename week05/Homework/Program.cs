using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Zack", "Fractions", "7.2", "2-10");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Jhon", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}