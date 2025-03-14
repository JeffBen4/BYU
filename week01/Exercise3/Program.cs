using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string response;
        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();

        } while (response == "yes");


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        

    }
}