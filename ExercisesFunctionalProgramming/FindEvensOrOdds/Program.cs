int[] range = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
string condition = Console.ReadLine();

int start = range[0];
int end = range[1];

List<int> filteredNumbers = new List<int>();
if (condition == "even")
{
    filteredNumbers = FilteredNumbersInRange(start, end, n => n % 2 == 0);
}
else if (condition == "odd")
{
    filteredNumbers = FilteredNumbersInRange(start, end, n => n % 2 != 0);
}

Console.WriteLine(string.Join(" ", filteredNumbers));

static List<int> FilteredNumbersInRange(int start, int end, Predicate<int> predicate)
{
    List<int> resultList = new List<int>();
    for (int i = start; i <= end; i++)
    {
        if (predicate(i))
        {
            resultList.Add(i);
        }
    }

    return resultList;
}