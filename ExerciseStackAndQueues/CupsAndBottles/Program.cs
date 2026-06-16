using System.Collections;

int[] cupsCapacity = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] filledBottles = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var queueOfCups = ReturnCups(cupsCapacity);
var stackOfBottles = ReturnBottlesAsStack(filledBottles);

int wastedLitres = 0;

while (queueOfCups.Count > 0 && stackOfBottles.Count > 0)
{
    int currentCup = queueOfCups.Peek();

    while (currentCup > 0 && stackOfBottles.Count > 0)
    {
        int currentBottle = stackOfBottles.Pop();
        currentCup -= currentBottle;
    }

    if (currentCup <= 0)
    {
        wastedLitres += Math.Abs(currentCup);
        queueOfCups.Dequeue();
    }

}

if (!queueOfCups.Any())
{
    Console.Write("Bottles: ");
    Console.WriteLine(string.Join(" ", stackOfBottles));
    Console.WriteLine($"Wasted litters of water: {wastedLitres}");
}


if (queueOfCups.Any())
{
    Console.Write("Cups: ");
    Console.WriteLine(string.Join(" ", queueOfCups));
    Console.WriteLine($"Wasted litters of water: {wastedLitres}");
}





static Queue<int> ReturnCups(int[] inputArray)
{
    var resultQueue = new Queue<int>();

    foreach (int num in inputArray)
    {
        resultQueue.Enqueue(num);
    }

    return resultQueue;
}


static Stack<int> ReturnBottlesAsStack(int[] inputArray)
{
    var resultStack = new Stack<int>();

    foreach (int num in inputArray)
    {
        resultStack.Push(num);
    }

    return resultStack;
}
