// This will intentionally cause a compiler error to display C# version info
// #error version
using System.Reflection;
using static System.Console;
namespace Vocabulary;  

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // WriteLine($"Computer named {Env.MachineName} says \"No.\"");
        // Get the assembly that is the entry point for this app.
        Assembly? myApp = Assembly.GetEntryAssembly();
        // If the previous line returned nothing then end the app.
        if (myApp is null) return;
        // Loop through the assemblies that my app references.
        foreach (AssemblyName name in myApp.GetReferencedAssemblies())
        {
            // Load the assembly so we can read its details.
            Assembly a = Assembly.Load(name);
            // Declare a variable to count the number of methods.
            int methodCount = 0;
            // Loop through all the types in the assembly.
            foreach (TypeInfo t in a.DefinedTypes)
            {
                // Add up the counts of all the methods.
                methodCount += t.GetMethods().Length;
            }
            // Output the count of types and their methods.
            WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
            arg0: a.DefinedTypes.Count(),
            arg1: methodCount,
            arg2: name.Name);
        }
        // Let the heightInMetres variable become equal to the value 1.88.
        double heightInMetres = 1.88;
        Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string grinningEmoji = char.ConvertFromUtf32(0x1F600);
        Console.WriteLine(grinningEmoji);

        int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
// Check the three variables have the same value.
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine(
$"{decimalNotation == hexadecimalNotation}");
// Output the variable values in decimal.
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");
// Output the variable values in hexadecimal.
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");
double x = 1.1;
Console.WriteLine(x);                 // 打印看似是 1.1
Console.WriteLine($"{x:F17}");      // 用 Round-trip 格式精确打印
if(1.1 == 1.10000000000000009)
{
    Console.WriteLine(true);
}else
{
    Console.WriteLine(false);
}
Console.WriteLine("Using doubles:");
double a1 = 0.1;
double b = 0.2;
if (a1 + b == 0.3)
{
Console.WriteLine($"{a1} + {b} equals {0.3}");
}
else
{
Console.WriteLine($"{a1} + {b} does NOT equal {0.3}");
}
Console.WriteLine("Using decimals:");
decimal c = 0.1M; // M suffix means a decimal literal value
decimal d = 0.2M;
if (c + d == 0.3M)
{
Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}
    }

}
