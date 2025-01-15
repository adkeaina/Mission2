// See https://aka.ms/new-console-template for more information

using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate? ");
        int nRolls = int.Parse(Console.ReadLine());
        Console.WriteLine(nRolls);
        
        // Create an array to store the frequency of each dice roll (2 through 12)
        int[] rollCounts = RollDice.DiceRoll(nRolls);
        
        // Display the results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {nRolls}.\n");

        // Loop through the roll counts and display them
        for (int i = 0; i < rollCounts.Length; i++)
        {
            int rollValue = i + 2; // Add 2 because array index 0 represents the sum of 2
            int percentage = (rollCounts[i] * 100) / nRolls;
            Console.WriteLine($"{rollValue}: {new string('*', percentage)}");
        }

        // Thank you message
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}