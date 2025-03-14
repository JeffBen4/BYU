using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string nota = "";

        if (percent >= 90)
        {
            nota = "A";
        }
        else if (percent >= 80)
        {
            nota = "B";
        }
        else if (percent >= 70)
        {
            nota = "C";
        }
        else if (percent >= 60)
        {
            nota = "D";
        }
        else
        {
            nota = "F";
        }

        Console.WriteLine($"Your grade is: {nota}");
    }
}