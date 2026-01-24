int targetNameLength = int.Parse(Console.ReadLine());
string[] inputNames = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .ToArray();

