using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelledDistance = 0;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set { TravelledDistance = value; }
        }

        public bool Drive(double distance)
        {
            double neededFuel = distance * this.fuelConsumptionPerKilometer;

            if (this.fuelAmount >= neededFuel)
            {
                this.fuelAmount -= neededFuel;
                this.travelledDistance += distance;

                return true;
            }

            return false;
        }
    }
}
