using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5._Speed_Racing
{
    public class Car
    {
        
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double FuelAmount, double FuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = FuelAmount;
            this.FuelConsumptionPerKilometer = FuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public bool IsTheFuelEnoughf(int kilometers)
        {
            if(this.FuelAmount*this.FuelConsumptionPerKilometer>kilometers)
            {
                return false;
            }
            else
            {
                this.FuelAmount = this.FuelAmount - (FuelConsumptionPerKilometer * kilometers);
                this.TravelledDistance+= kilometers;
                return true;
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance}"; 
        }

    }
}
