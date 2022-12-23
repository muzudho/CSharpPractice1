// See https://aka.ms/new-console-template for more information

using System.Reflection;

// ディレクトリ・パスをコンソールへ標準出力します
static void EchoDirectory()
{
    string currentDirectory = Directory.GetCurrentDirectory();
    string executeAssemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "null";

    Console.WriteLine($@"Data
---------------------------
Current Directory         : {currentDirectory}
Execute Assembly Directory: {executeAssemblyDirectory}

Please, Push any key.
");

    Console.ReadKey();
}

EchoDirectory();
