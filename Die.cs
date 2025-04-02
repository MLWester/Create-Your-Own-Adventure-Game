public class Die
{
    private static readonly Random random = new Random();
    
    public int Roll()
    {
        return random.Next(1, 21);
    }
}