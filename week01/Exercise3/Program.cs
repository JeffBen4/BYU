using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        Console.Write("What is your guess? ");
        int response = int.Parse(Console.ReadLine());

        while (number != response)
        {
            if (response > number)
            {
                Console.WriteLine("Lower");
                Console.Write("Try again: ");
                response = int.Parse(Console.ReadLine());
            }
            if (response < number)
            {
                Console.WriteLine("Higher");
                Console.Write("Try again: ");
                response = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("You guessed it!");

        

    }
}