int[] inputNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .Select(int.Parse)
    .ToArray();

int targetDivider = int.Parse(Console.ReadLine());

int[] reversedArray = ReverseCollection(inputNumbers);
int[] filteredArray = RemoveDivisibleElements(reversedArray, n => n % targetDivider != 0);

Console.WriteLine(string.Join(" ", filteredArray));


static int[] RemoveDivisibleElements(int[] array, Func<int, bool> func)
{
    List<int> resultNumbers = new List<int>();
    foreach (var number in array)
    {
        if (func(number))
        {
            resultNumbers.Add(number);
        }
    }

    return resultNumbers.ToArray();
}


static int[] ReverseCollection(int[] array)
{
    return array.Reverse().ToArray();
}