using SpeedRacing;

int N = int.Parse(Console.ReadLine());

var cars = new List<Car>();

for (int i = 0; i < N; i++)
{
    string[] inputData = Console.ReadLine()
        .Split();

    string currentModel = inputData[0];
    double currentFuelAmount = double.Parse(inputData[1]);
    double currentFuelConsumptionFor1km = double.Parse(inputData[2]);

    Car currentCar = new Car(currentModel, currentFuelAmount, currentFuelConsumptionFor1km);

    cars.Add(currentCar);
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "End")
{
    string[] inputData = command.Split();

    string carModel = inputData[1];
    double amountOfKm = double.Parse(inputData[2]);

    Car currentCar = cars.First(c => c.Model == carModel);

    bool positive = currentCar.Drive(amountOfKm);

    if (!positive)
    {
        Console.WriteLine("Insufficient fuel for the drive");
    }
}

foreach (Car car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
}



/*
2
AudiA4 23 0.3
BMW-M2 45 0.42
Drive BMW-M2 56
Drive AudiA4 5
Drive AudiA4 13
End


3
AudiA4 18 0.34
BMW-M2 33 0.41
Ferrari-488Spider 50 0.47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End
 */