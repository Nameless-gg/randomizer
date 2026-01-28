using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        PrintSlowWithDot("Starting the process");
        PrintSlowWithDot("Processing data");
        PrintSlowWithDot("Process completed successfully");
        Console.WriteLine("Program ready to work.");
        Thread.Sleep(400);
        Console.WriteLine("Please write something you need to random.");
        Thread.Sleep(400);
        Console.WriteLine("Exemple:");
        Console.WriteLine("1 2 3 4 5");

        Console.Write("> ");
        string input = Console.ReadLine();

        string[] options = input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();

        if (options.Length == 0)
        {
            Console.WriteLine("Program cant work with nothing, write something");
            return;
        }

        PrintSlowWithDot("randomizer start to work");
        PrintSlowWithDot("randomizer start to work");
        PrintSlowWithDot("Analyzing input");
        PrintSlowWithDot("Generating output");

        Random random = new Random();
        int index = random.Next(options.Length);
        string result = options[index];

        Console.WriteLine($"You asking me to choose one of the | {string.Join(" | ", options)} |");
        Thread.Sleep(500);
        Console.Write("And i pick");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }
        Console.Write(" ");
        Thread.Sleep(1000);
        Console.Write(result);
        Thread.Sleep(500);

        Console.WriteLine();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

    }
    static void PrintSlowWithDot(string text, int delay = 400)
    {
        Console.Write(text);
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(200);
            Console.Write(".");
        }
        Thread.Sleep(delay);
        Console.WriteLine();
    }
}