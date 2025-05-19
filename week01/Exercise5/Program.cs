using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favNumber = PromptUserNumber();

        int squareNumber = SquareNumber(favNumber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number? ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}