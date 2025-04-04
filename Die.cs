using System;

public class Die
{
    private static readonly Random random = new Random();

    // The number of sides is passed each time Roll is called
    public int Roll(int sides)
    {
        return random.Next(1, sides + 1);
    }
}
