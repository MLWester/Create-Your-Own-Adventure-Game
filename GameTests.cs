using System;

public class GameTest
{
    public void RunAllTests()
    {
        TestGameInitialization();
    }

    private void TestGameInitialization()
    {
        try
        {
            Messages messages = new Messages();
            messages.ReadDictionary("English");

            Game game = new Game(messages);

            Console.WriteLine("Game test 1 - game initialized: ✅ PASS");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Game test 1 - game initialization: ❌ FAIL ({ex.Message})");
        }
    }
}
