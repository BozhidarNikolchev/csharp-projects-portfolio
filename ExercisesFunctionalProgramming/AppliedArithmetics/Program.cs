int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
    if (command == "add")
        inputNumbers = PerformMathOperation(inputNumbers, n => n + 1);

    if (command == "multiply")
        inputNumbers = PerformMathOperation(inputNumbers, n => n * 2);

    if (command == "subtract")
        inputNumbers = PerformMathOperation(inputNumbers, n => n - 1);

    if (command == "print")
        Console.WriteLine(string.Join(" ", inputNumbers));
}


static int[] PerformMathOperation(int[] array, Func<int, int> func)
{
    var resultList = new List<int>();
    foreach (var number in array)
    {
        resultList.Add(func(number));
    }

    return resultList.ToArray();
}