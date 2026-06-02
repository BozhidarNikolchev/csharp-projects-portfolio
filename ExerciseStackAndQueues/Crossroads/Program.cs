int greenLightInSec = int.Parse(Console.ReadLine());
int freeWindowInSec = int.Parse(Console.ReadLine());

var cars = new Queue<string>();

int totalCarsPassed = 0;
char characterHit = ' ';
bool crashHappened = false;
string crashedCar = string.Empty;

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    if (command == "green")
    {
        int greenLightOps = greenLightInSec;

        while (cars.Count > 0 && greenLightOps > 0)
        {
            string currentCar = cars.Peek();
            int carLength = currentCar.Length;

            if (carLength <= greenLightOps)
            {
                greenLightOps = greenLightOps - carLength;
                totalCarsPassed++;
                cars.Dequeue();
            }
            else
            {
                int totalTime = greenLightOps + freeWindowInSec;
                if (carLength <= totalTime)
                {
                    totalCarsPassed++;
                    cars.Dequeue();
                }
                else
                {
                    characterHit = currentCar[totalTime];
                    crashHappened = true;
                    crashedCar = currentCar;
                }

                break;
            }
        }

        if (crashHappened)
        {
            break;
        }
    }
    else
    {
        cars.Enqueue(command);
    }
}


if (crashHappened)
{
    Console.WriteLine("A crash happened!");
    Console.WriteLine($"{crashedCar} was hit at {characterHit}.");
}
else
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
}
