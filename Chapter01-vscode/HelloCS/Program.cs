// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! This is my first C# program.");
string name = typeof(Program).Namespace ?? "None!";
Console.WriteLine($"The namespace of this program is: {name}");
throw new Exception();