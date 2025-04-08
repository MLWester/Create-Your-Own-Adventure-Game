using System;

public class MessagesTests
{
    public void RunAllTests()
    {
        Console.WriteLine("=== Messages System Tests ===\n");

        TestMessageRetrieval("English");
        TestMessageRetrieval("French");
        TestMessageRetrieval("Spanish");
        TestFallbackMessage();
        
        Console.WriteLine("\n=== End of Messages System Tests ===\n");
    }

    private void TestMessageRetrieval(string language)
    {
        Messages messages = new Messages();
        messages.ReadDictionary(language);

        // Try to retrieve a few known keys
        string welcome = messages.GetMessage(201);
        string menu = messages.GetMessage(202);
        string invalid = messages.GetMessage(203);

        Console.WriteLine($"Language: {language}");
        Console.WriteLine($"Message 201 (Welcome): {(string.IsNullOrWhiteSpace(welcome) ? "❌ FAIL" : "✅ PASS")} - {welcome}");
        Console.WriteLine($"Message 202 (Menu): {(string.IsNullOrWhiteSpace(menu) ? "❌ FAIL" : "✅ PASS")} - {menu}");
        Console.WriteLine($"Message 203 (Invalid input): {(string.IsNullOrWhiteSpace(invalid) ? "❌ FAIL" : "✅ PASS")} - {invalid}");
        Console.WriteLine();
    }

    private void TestFallbackMessage()
    {
        Messages messages = new Messages();
        messages.ReadDictionary("English");

        string fallback = messages.GetMessage(999); // Invalid key
        bool result = fallback.Contains("Missing message");

        Console.WriteLine("Fallback Message Test:");
        Console.WriteLine(result ? $"✅ PASS - {fallback}" : $"❌ FAIL - {fallback}");
    }
}
