using System;
using System.Collections.Generic;

public class MessagesTests
{
    public void RunAllTests()
    {
        Console.WriteLine("=== Messages System Tests ===\n");

        string[] languages = { "English", "French", "Spanish" };
        int[] keysToTest = { 101, 105, 114, 201, 301, 310, 314 }; // Core message keys

        foreach (string language in languages)
        {
            TestLanguageMessages(language, keysToTest);
        }

        TestFallbackMessage();

        Console.WriteLine("\n=== End of Messages System Tests ===\n");
    }

    private void TestLanguageMessages(string language, int[] keys)
    {
        Messages messages = new Messages();
        messages.ReadDictionary(language);

        Console.WriteLine($"--- Testing Messages for Language: {language} ---");
        foreach (int key in keys)
        {
            string msg = messages.GetMessage(key);
            if (string.IsNullOrWhiteSpace(msg))
            {
                Console.WriteLine($"Key {key}: ❌ FAIL - Missing or empty message.");
            }
            else
            {
                Console.WriteLine($"Key {key}: ✅ PASS - {msg}");
            }
        }
        Console.WriteLine();
    }

    private void TestFallbackMessage()
    {
        Messages messages = new Messages();
        messages.ReadDictionary("English");

        string result = messages.GetMessage(999); // Invalid key
        bool fallbackWorks = result.Contains("Missing message");

        Console.WriteLine("--- Fallback Message Test ---");
        Console.WriteLine(fallbackWorks ? $"✅ PASS - {result}" : $"❌ FAIL - {result}");
    }
}
