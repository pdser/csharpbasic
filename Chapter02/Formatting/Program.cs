using static System.Console;
namespace Formatting;

class Program
{
    static void Main(string[] args)
    {
        int numberOfApples = 12;
        decimal pricePerApple = 0.35M;
        Console.WriteLine(
        format: "{0} apples cost {1:C}",
        arg0: numberOfApples,
        arg1: pricePerApple * numberOfApples);
        string formatted = string.Format(
        format: "{0} apples cost {1:C}",
        arg0: numberOfApples,
        arg1: pricePerApple * numberOfApples);
        //WriteToFile(formatted); // Writes the string into a file.

        // Three parameter values can use named arguments.
        Console.WriteLine("{0} {1} lived in {2}.",
        arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
        // Four or more parameter values cannot use named arguments.
        Console.WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
        "Roger", "Cevung", "Stockholm", "Education", "Optimizely");
        Console.Write("Type your first name and press ENTER: ");
        string firstName = Console.ReadLine();
        Console.Write("Type your age and press ENTER: ");
        string age = Console.ReadLine();
        Console.WriteLine($"Hello {firstName}, you look good for {age}.");

        Write("Press any key combination: ");
        ConsoleKeyInfo key = ReadKey();
        WriteLine();
        WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
        arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);


        HttpClient client = new();
        HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
        WriteLine("Apple's home page has {0:N0} bytes.",
        response.Content.Headers.ContentLength);

    }
}
