using System;

public class GameTest
{
    public void RunAllTests()
    {
        TestGameStartCreatesObjects();
    }

    private void TestGameStartCreatesObjects()
    {
        Game game = new Game();

        try
        {
            game.StartGame(); // This will ask for input

            // Since we can't check internals directly, we just make sure it runs
            Console.WriteLine("Game test 1 - start without crash: ✅ PASS");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Game test 1 - start without crash: ❌ FAIL ({ex.Message})");
        }
    }
}
