using System;

public class DieTest
{
    public void RunAllTests()
    {
        TestRollWithinRange();
        TestRollProducesVariation();
    }

    private void TestRollWithinRange()
    {
        Die die = new Die();
        bool allInRange = true;

        for (int i = 0; i < 100; i++)
        {
            int result = die.Roll(20);
            if (result < 1 || result > 20)
            {
                allInRange = false;
                break;
            }
        }

        Console.WriteLine("Die test 1 - range test: " + (allInRange ? "✅ PASS" : "❌ FAIL"));
    }

    private void TestRollProducesVariation()
    {
        Die die = new Die();
        int firstRoll = die.Roll(20);
        bool variationFound = false;

        for (int i = 0; i < 10; i++)
        {
            int nextRoll = die.Roll(20);
            if (nextRoll != firstRoll)
            {
                variationFound = true;
                break;
            }
        }

        Console.WriteLine("Die test 2 - variation test: " + (variationFound ? "✅ PASS" : "❌ FAIL"));
    }
}

