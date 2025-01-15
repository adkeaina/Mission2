namespace Mission2;

public class RollDice
{
    public static int[] DiceRoll(int nRolls)
    {
        int[] rollCounts = new int[12];
        
        // Initialize random number generator
        Random rand = new Random();

        // Simulate the dice rolls
        for (int i = 0; i < nRolls; i++)
        {
            int die1 = rand.Next(1, 7); // Random number between 1 and 6 for the first die
            int die2 = rand.Next(1, 7); // Random number between 1 and 6 for the second die
            int rollSum = die1 + die2; // Sum the two dice rolls
            rollCounts[rollSum - 2]++; // Increment the corresponding sum's index in the array
        }
        
        return rollCounts;
    }
}