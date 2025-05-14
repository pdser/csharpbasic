using System.Threading.Tasks;
using static System.Console;
using System;
using System.Threading.Tasks;
namespace Formatting;

class Program
{
    static async Task Main(string[] args)
    {
        // int numberOfApples = 12;
        // decimal pricePerApple = 0.35M;
        // Console.WriteLine(
        // format: "{0} apples cost {1:C}",
        // arg0: numberOfApples,
        // arg1: pricePerApple * numberOfApples);
        // string formatted = string.Format(
        // format: "{0} apples cost {1:C}",
        // arg0: numberOfApples,
        // arg1: pricePerApple * numberOfApples);
        // //WriteToFile(formatted); // Writes the string into a file.

        // // Three parameter values can use named arguments.
        // Console.WriteLine("{0} {1} lived in {2}.",
        // arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
        // // Four or more parameter values cannot use named arguments.
        // Console.WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
        // "Roger", "Cevung", "Stockholm", "Education", "Optimizely");
        // Console.Write("Type your first name and press ENTER: ");
        // string firstName = Console.ReadLine();
        // Console.Write("Type your age and press ENTER: ");
        // string age = Console.ReadLine();
        // Console.WriteLine($"Hello {firstName}, you look good for {age}.");

        // Write("Press any key combination: ");
        // ConsoleKeyInfo key = ReadKey();
        // WriteLine();
        // WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
        // arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);


        // HttpClient client = new();
        // HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
        // WriteLine("Apple's home page has {0:N0} bytes.",
        // response.Content.Headers.ContentLength);
        // Console.WriteLine("1:" + Thread.CurrentThread.ManagedThreadId);
        // HttpClient client = new HttpClient();
        // string html = await client.GetStringAsync("http://www.apple.com/");
        // //Task<string> task = client.GetStringAsync("http://www.apple.com/");
        // //string html = task.GetAwaiter().GetResult();
        // await Task.Delay(1000);
        // await WriteToFile(html);
        // Console.WriteLine("4:" + Thread.CurrentThread.ManagedThreadId);
        //     Console.WriteLine("===== 示例 1：不使用 await，启动即走，顺序失控 =====");

        //     RunWithoutAwait();

        //     await Task.Delay(1500);  // 等待所有任务完成再继续看输出

        //     Console.WriteLine("\n===== 示例 2：使用 await 控制顺序 =====");

        //     await RunWithAwait();


        //     static async Task RunWithoutAwait()
        //     {
        //         Task taskA = TaskA();  // 不 await，直接启动
        //         Task taskB = TaskB();  // 不 await，直接启动
        //         Console.WriteLine("Main function continued without waiting A or B.");
        //         // ⚠️ 顺序不可控，哪个先完成取决于延迟
        //     }

        //     static async Task RunWithAwait()
        //     {
        //         await TaskA();  // 等 A 完成，再继续
        //         await TaskB();  // 等 B 完成，再继续
        //         Console.WriteLine("Main function waited A then B, in order.");
        //     }


        //     static async Task TaskA()
        //     {
        //         await Task.Delay(10000);  // 模拟 A 比较慢
        //         Console.WriteLine("✅ Task A completed");
        //         Console.WriteLine("A:" + Thread.CurrentThread.ManagedThreadId);
        //     }

        //     static async Task TaskB()
        //     {   
        //         await Task.Delay(300);  // 模拟 B 比较快
        //         Console.WriteLine("✅ Task B completed");
        //         Console.WriteLine("B:" + Thread.CurrentThread.ManagedThreadId);

        //     }



        // }

        // public static async Task WriteToFile(string formatted)
        // {
        //     // Implementation to write the formatted string to a file.
        //     // This is just a placeholder for the actual implementation.
        //     Console.WriteLine("2:" + Thread.CurrentThread.ManagedThreadId);
        //     await File.WriteAllTextAsync("output.txt", formatted);
        //     Console.WriteLine("Formatted string written to output.txt");
        //     Console.WriteLine("3:" + Thread.CurrentThread.ManagedThreadId);
        // }
        Console.WriteLine("Main Started");
        Console.WriteLine($"[Main] Thread ID: {Thread.CurrentThread.ManagedThreadId}");

        await DoWorkAsync("A", 1000);
        await DoWorkAsync("B", 1000);
        await DoWorkAsync("C", 1000);
        Console.WriteLine("Main Finished");
        Console.WriteLine($"[Main] Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }
    static async Task DoWorkAsync(string tag, int delay)
    {
        Console.WriteLine($"[{tag}] Started on Thread: {Thread.CurrentThread.ManagedThreadId}");

        await Task.Delay(delay);  // 模拟异步任务（不会占用线程）
        
        Console.WriteLine($"[{tag}] Resumed after await on Thread: {Thread.CurrentThread.ManagedThreadId}");
    }
}
