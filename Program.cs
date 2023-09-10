
    if (args.Length > 0)
    {
        foreach (string line in args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(line);
            Console.WriteLine("---------------------------------------------------------------");
            Read(line);
        }
    }

Console.ReadKey();

void Read(string path)
{
    string[] lines = File.ReadAllLines(path);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}