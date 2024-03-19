using System;

class Program
{
    static void Main(string[] args)
    {
        bool exitRequested = false;

        do
        {
            Console.Clear(); // Clear the console for a better UI
            PrintAsciiArt();
            ShowMainMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConditionalStatement();
                    break;
                case "2":
                    LoopStatement();
                    break;
                case "3":
                    exitRequested = Exit();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

        } while (!exitRequested);
    }

    static void PrintAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("   _____ _                 _        ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("_____                                       ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("__  __                  ");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n  / ____(_)               | |      ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("|  __ \\                                     ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("|  \\/  |                 ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n | (___  _ _ __ ___  _ __ | | ___  ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("| |__) | __ ___   __ _ _ __ __ _ _ __ ___   ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("| \\  / | ___ _ __  _   _ ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n  \\___ \\| | '_ ` _ \\| '_ \\| |/ _ \\ ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("|  ___/ '__/ _ \\ / _` | '__/ _` | '_ ` _ \\  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("| |\\/| |/ _ \\ '_ \\| | | |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n  ____) | | | | | | | |_) | |  __/ ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("| |   | | | (_) | (_| | | | (_| | | | | | | ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("| |  | |  __/ | | | |_| |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n |_____/|_|_| |_| |_| .__/|_|\\___| ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("|_|   |_|  \\___/ \\__, |_|  \\__,_|_| |_| |_| ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("|_|  |_|\\___|_| |_|\\__,_|");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n                    ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("| |                              ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("__/ |                                               ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n                    ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("|_|                             ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("|___/           ");

        Console.ResetColor(); // Reset color back to default
    }

    static void ShowMainMenu()
    {
        Console.WriteLine("Welcome to the Program");
        Console.WriteLine("Main Menu");
        Console.WriteLine("[1] Conditional Statement");
        Console.WriteLine("[2] Loop Statement");
        Console.WriteLine("[3] Exit");
    }

    static void ConditionalStatement()
    {
        Console.Clear();
        Console.WriteLine("Check if a Number is Odd or Even");
        Console.Write("Enter a number: ");
        int number;

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            Console.Write("Enter a number: ");
        }

        if (number % 2 == 0)
        {
            Console.WriteLine($"Number {number} is an Even Number");
        }
        else
        {
            Console.WriteLine($"Number {number} is an Odd Number");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    static void LoopStatement()
    {
        Console.Clear();
        Console.WriteLine("Repeat a Word Multiple Times");
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        Console.WriteLine($"Repeating '{word}' {word.Length} times:");

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    static bool Exit()
    {
        Console.Clear();
        Console.WriteLine("Exit Program");
        Console.Write("Full Name: Jhon Keneth Ryan B. Namias\n");
        Console.Write("Course/Yr./ Sec.: BSCS - 2A\n");
        Console.Write("Subject Code: CS 105\n");
        Console.Write("Type 'exit' to confirm exit: ");
        string exitConfirmation = Console.ReadLine();

        if (exitConfirmation.ToLower() == "exit")
        {
            Console.WriteLine("Exiting program...");
            return true;
        }
        else
        {
            Console.WriteLine("Exit confirmation failed. Returning to main menu.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return false;
        }
    }
}
