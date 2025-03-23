using System;

class Task3
{
    static void Main()
    {
        // Ask the user for their name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Welcome the user
        Console.WriteLine($"Welcome, {name} :)");

        // Create an array to store 10 numbers
        double[] numbers = new double[10];

        // Ask the user the enter 10 numbers
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Please enter number {i + 1}: ");
            // Store the users enter numbers into an array
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Modify the numbers based on order entered
        for (int i = 0; i < 10; i++)
        {
            // Divide each number by its index position index + 1 
            numbers[i] = numbers[i] / (i + 1);
        }

        // Display the modified numbers to the user
        Console.WriteLine("\nHere are your modified numbers:");
        for (int i = 0; i < 10; i++)
        {
            // Display each modified number and format it to two decimal places
            Console.WriteLine($"Number {i + 1}: {numbers[i]:F2}");
        }
    }
}
