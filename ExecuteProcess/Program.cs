// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

foreach (string arg in args)
{
    Console.WriteLine($@"arg: {arg}");
}

var app = new ProcessStartInfo();

// Example: "notepad";
app.FileName = args[0];

// Example: "memo.txt";
app.Arguments = args[1];

Process.Start(app);
