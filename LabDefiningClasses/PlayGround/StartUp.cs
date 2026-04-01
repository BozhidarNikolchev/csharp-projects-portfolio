namespace CarManufacturer
{
    public class StartUp
    {
        private static List<Tire[]> tires = new List<Tire[]>();
        private static List<Engine> engines = new List<Engine>();
        private static List<Car> cars = new List<Car>();
        static void Main()
        {
            ProcessTires();
            ProcessEngines();
            ProcessCars();
            DriveAndPrint();
        }

        private static void ProcessTires()
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "No more tires")
                {
                    break;
                }

                string[] inputData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int firstYear = int.Parse(inputData[0]);
                double firstPressure = double.Parse(inputData[1]);
                int secondYear = int.Parse(inputData[2]);
                double secondPressure = double.Parse(inputData[3]);
                int thirdYear = int.Parse(inputData[4]);
                double thirdPressure = double.Parse(inputData[5]);
                int fourthYear = int.Parse(inputData[6]);
                double fourthPressure = double.Parse(inputData[7]);

                var fullSetOfTires = new Tire[]
                {
                    new Tire(firstYear, firstPressure),
                    new Tire(secondYear, secondPressure),
                    new Tire(thirdYear, thirdPressure),
                    new Tire(fourthYear, fourthPressure)
                 };

                tires.Add(fullSetOfTires);
            }
        }

        private static void ProcessEngines()
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Engines done")
                {
                    break;
                }

                string[] inputData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(inputData[0]);
                double cubicCapacity = double.Parse(inputData[1]);

                var currentEngine = new Engine(horsePower, cubicCapacity);

                engines.Add(currentEngine);
            }
        }

        private static void ProcessCars()
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Show special")
                {
                    break;
                }

                string[] inputData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = inputData[0];
                string model = inputData[1];
                int year = int.Parse(inputData[2]);
                double fuelQuantity = double.Parse(inputData[3]);
                double fuelConsumption = double.Parse(inputData[4]);
                int engineIndex = int.Parse(inputData[5]);
                int tiresIndex = int.Parse(inputData[6]);

                var engine = engines[engineIndex];
                var setOfTires = tires[tiresIndex];

                var currentCar = new Car(make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumption,
                    engine,
                    setOfTires);

                cars.Add(currentCar);
            }
        }

        private static void DriveAndPrint()
        {
            var resultCars = cars.Where(car => car.Year >= 2017)
                .Where(car => car.Engine.HorsePower > 330)
                .Where(car =>
                {
                    var tiresPressure = car.Tires.Select(t => t.Pressure);

                    return tiresPressure.Sum() >= 9 && tiresPressure.Sum() <= 10;
                })
            .ToList();

            foreach (var car in resultCars)
            { 
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}


///////////////////////////////////////////////////////////////////////////////////////////////


//string make = Console.ReadLine();
//string model = Console.ReadLine();
//int year = int.Parse(Console.ReadLine());
//double fuelQuantity = double.Parse(Console.ReadLine());
//double fuelConsumption = double.Parse(Console.ReadLine());

//Car firstCar = new Car();
//Car secondCar = new Car(make, model, year);
//Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);


///////////////////////////////////////////////////////////////////////////

//var tires = new Tire[4]
//{
//    new Tire(1, 2.5),
//    new Tire(1, 2.1),
//    new Tire(2, 0.5),
//    new Tire(2, 2.3)
//};

//var engine = new Engine(560, 6300);

//var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);


///////////////////////////////////////////////////////////////////////////////////